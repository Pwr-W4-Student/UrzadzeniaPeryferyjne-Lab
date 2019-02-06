/*******************************************************************************
Copyright (c) 1983-2012 Advantech Co., Ltd.
********************************************************************************
THIS IS AN UNPUBLISHED WORK CONTAINING CONFIDENTIAL AND PROPRIETARY INFORMATION
WHICH IS THE PROPERTY OF ADVANTECH CORP., ANY DISCLOSURE, USE, OR REPRODUCTION,
WITHOUT WRITTEN AUTHORIZATION FROM ADVANTECH CORP., IS STRICTLY PROHIBITED. 

  ================================================================================
  REVISION HISTORY
  --------------------------------------------------------------------------------
  $Log:  $
  --------------------------------------------------------------------------------
  $NoKeywords:  $
*/
/******************************************************************************
*
* Windows Example:
*    InstantAI.cs
*
* Example Category:
*    AI
*
* Description:
*    This example demonstrates how to use Instant AI function.
*
* Instructions for Running:
*    1. Set the 'deviceDescription' for opening the device. 
*    2. Set the 'startChannel' as the first channel for scan analog samples  
*    3. Set the 'channelCount' to decide how many sequential channels to scan analog samples.
*
* I/O Connections Overview:
*    Please refer to your hardware reference manual.
*
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;
using Automation.BDaq;

namespace AI_InstantAI
{
    class InstantAI
    {

        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------
            // Configure the following three parameters before running the demo
            //-----------------------------------------------------------------------------------
            //The default device of project is demo device, users can choose other devices according to their needs. 
            //string deviceDescription = "DemoDevice,BID#0";
            string deviceDescription = "USB-4702,BID#0";
            int startChannel = 4;
            const int channelCount = 1;

            ErrorCode errorCode = ErrorCode.Success;

            // Ilosc probek = 250, Czas akwizycji - 1s, Czas miedzy probkami - 1/256 s, Czestotliwosc probkowania 256 Hz
            // Spelnia Twierdzenie Kotielnikowa-Shannona (badany sygnal ma czestliwosc 100 Hz)
            int sampleIter = 0;
            int sampleCount = 256;
            float sampleFrequency = 100; //[Hz]
            float timeSample = (1f / sampleFrequency) * 1000;
            int timeSample_i = (int)Math.Round(timeSample); //[ms]

            // int convertClkRatePerChan = 1000;

            // Step 1: Create a 'InstantAiCtrl' for Instant AI function.
            InstantAiCtrl instantAIContrl = new InstantAiCtrl();

            try
            {
                // Step 2: Select a device by device number or device description and specify the access mode.
                // in this example we use AccessWriteWithReset(default) mode so that we can 
                // fully control the device, including configuring, sampling, etc.
                instantAIContrl.SelectedDevice = new DeviceInformation(deviceDescription);

                // Step 3: Read samples and do post-process, we show data here.
                Console.WriteLine(" InstantAI is in progress...\n");
                int channelCountMax = instantAIContrl.Features.ChannelCountMax;
                double[] scaledData = new double[channelCount];//the count of elements in this array should not be less than the value of the variable channelCount
                for (int i = 0; i < channelCount; ++i)
                {
                    Console.Write("    channel: {0}", (i % channelCount + startChannel) % channelCountMax);
                }

                Console.WriteLine();
                using (System.IO.StreamWriter file =
                     new System.IO.StreamWriter(@"probki.txt"))
                    do
                    {
                        // read samples, just scaled data in this demo
                        errorCode = instantAIContrl.Read(startChannel, channelCount, scaledData);
                        if (BioFailed(errorCode))
                        {
                            throw new Exception();
                        }
                        // process the acquired samples
                        for (int i = 0; i < channelCount; ++i)
                        {
                            Console.Write(" {0,11:f8}", scaledData[i]);
                            file.WriteLine(" {0,11:f8}", scaledData[i]);
                        }
                        Console.Write("\n");
                        sampleIter++;
                        Thread.Sleep(timeSample_i);
                    } while (sampleIter < sampleCount);
            }
            catch (Exception e)
            {
                // Something is wrong
                string errStr = BioFailed(errorCode) ? " Some error occurred. And the last error code is " + errorCode.ToString()
                                                      : e.Message;
                Console.WriteLine(errStr);
            }
            finally
            {
                // Step 4: Close device and release any allocated resource.
                instantAIContrl.Dispose();
                Console.ReadKey(false);
            }
        }

        static bool BioFailed(ErrorCode err)
        {
            return err < ErrorCode.Success && err >= ErrorCode.ErrorHandleNotValid;
        }
    }
}
