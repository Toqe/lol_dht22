rm libdht.so
gcc -c -Wall -Werror -fPIC libdht.c
# gcc -shared -o libdht.so libdht.o 
gcc -shared -Wl,-soname,libdht.so.1 -lwiringPi -o libdht.so *.o

