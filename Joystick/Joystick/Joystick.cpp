#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#include <dinput.h>
#include <wchar.h>
#pragma comment(lib,"dinput8.lib")
#pragma comment(lib,"dxguid.lib")

using namespace std;

LPDIRECTINPUT8 DirectInput;
LPDIRECTINPUTDEVICE8 GamePad;

BOOL CALLBACK enumCallback(const DIDEVICEINSTANCE* instance, VOID* context){
	HRESULT pom;
	pom = DirectInput->CreateDevice(instance->guidInstance, &GamePad, NULL);
	if (FAILED(pom)){
		return DIENUM_CONTINUE;
	}
	return DIENUM_STOP;
}
// zwracanie wartosci osi x i y
BOOL CALLBACK enumAxesCallback(const DIDEVICEOBJECTINSTANCE*instance, VOID* context)
{

	HWND hDlg = (HWND)context;
	DIPROPRANGE propRange;
	propRange.diph.dwSize = sizeof(DIPROPRANGE); //rozmiar zalaczonej struktury
	propRange.diph.dwHeaderSize = sizeof(DIPROPHEADER);//ROZMIAR struktury
	propRange.diph.dwHow = DIPH_BYID; //INDETYFIKATOR ZWRACANY W ELEMENCIE dwtype struktury dideviobjectinstance
	propRange.diph.dwObj = instance->dwType; //wartosc ustawiona
	propRange.lMin = -1000; //DOLNA GRANICA ZASIEGU
	propRange.lMax = 1000; //GORNA GRANICA ZASIEGU
	//ZAKRES UKADU
	if (FAILED(GamePad->SetProperty(DIPROP_RANGE, &propRange.diph)))
	{
		return DIENUM_STOP;
	}
	return DIENUM_CONTINUE;
}
// funkcja poll sluzy do uzyskania informacji na temat stanu naszych przyciskow i naszej pozycji joysitcka w przestrzeni
HRESULT poll(DIJOYSTATE*js)
{
	HRESULT pom;
	if (GamePad == NULL)
	{
		return S_OK;
	}
	//odczyt joysticka czy mozemy go dalej uzywac
	pom = GamePad->Poll();
	if (FAILED(pom))
	{
		//przywracanie polaczenia jesli strumien zostal przerwany
		pom = GamePad->Acquire();
		while (pom = DIERR_INPUTLOST){
			pom = GamePad->Acquire();
		}
		if ((pom == DIERR_INVALIDPARAM) || (pom == DIERR_NOTINITIALIZED)){
			return E_FAIL;
		}
		//jesli inna aplikacja ma kontrole poczeka az kontroler sie zwolni
		if (pom = DIERR_OTHERAPPHASPRIO)
			return S_OK;
	}
	//odczyt stanu urzadzenia
	if (FAILED(pom = GamePad->GetDeviceState(sizeof(DIJOYSTATE), js))){
		return pom;
	}
	return S_OK;
}

int main()
{
	HRESULT pom;
	if (FAILED(pom = DirectInput8Create(GetModuleHandle(NULL), DIRECTINPUT_VERSION, IID_IDirectInput8, (VOID**)&DirectInput, NULL))){
		return 1;
	}

	if (FAILED(pom = DirectInput->EnumDevices(DI8DEVCLASS_GAMECTRL, enumCallback, NULL, DIEDBSFL_ATTACHEDONLY))){
		return 1;
	}

	if (GamePad == NULL){
		cout << "Nie znaleziono urzadzenia" << endl;
		system("pause");
		return E_FAIL;
	}
	else{
		cout << "Znaleziono urzadzenie" << endl;
		DIDEVICEINSTANCE info;
		info.dwSize = sizeof(DIDEVICEINSTANCE);
		GamePad->GetDeviceInfo(&info);
		wchar_t* NazwaPada = info.tszProductName;
		wprintf(NazwaPada);
		cout << endl; 
	}
	DIDEVCAPS capabilities;
	if (FAILED(pom = GamePad->SetDataFormat(&c_dfDIJoystick))){
		return 1;
	}
	capabilities.dwSize = sizeof(DIDEVCAPS);
	if (FAILED(pom = GamePad->GetCapabilities(&capabilities))){
		return 1;
	}
	if (FAILED(pom = GamePad->EnumObjects(enumAxesCallback, NULL, DIDFT_AXIS))){
		return 1;
	}
	DIJOYSTATE state;
	POINT cursor;
	int klik = -1;
	//oczekiwanie na akcje uzytkownika 
	cout << "Uzyj pada" << endl;
	int koniec = 0;
	BlockInput(true);
	while (poll(&state)){
		for (int i = 0; i < 32; i++){
			if (state.rgbButtons[klik] == 0){
				if (klik == 0){
					GetCursorPos(&cursor);
					mouse_event(MOUSEEVENTF_LEFTUP, cursor.x, cursor.y, 0, 0);
				}
				klik = -1;
			}
			if (state.rgbButtons[i] && klik != i){
				klik = i;
				if (i == 0){
					GetCursorPos(&cursor);
					mouse_event(MOUSEEVENTF_LEFTDOWN, cursor.x, cursor.y, 0, 0);
				}
				else if (i == 1){
					GetCursorPos(&cursor);
					mouse_event(MOUSEEVENTF_RIGHTUP, cursor.x, cursor.y, 0, 0);
				}
				else if (i == 2){
					koniec++;
				}
			}
		}
		GetCursorPos(&cursor);
		SetCursorPos((cursor.x + state.lX) / 100, (cursor.y + state.lY) / 100);
		Sleep(10);
		if (koniec != 0){
			break;
		}
	}
	
		if (GamePad){
			GamePad->Unacquire();
		}
	
	system("pause");
	return 1;
}

