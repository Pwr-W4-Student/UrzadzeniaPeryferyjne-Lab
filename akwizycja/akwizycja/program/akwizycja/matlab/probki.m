load probki.txt

[n,p] = size(probki);

t = 1:n;
t = t/n;


plot(t,probki), 
xlabel('Czas[s]'), ylabel('Napiecie[V]')
title('Przebieg sygnalu prostokatnego')
