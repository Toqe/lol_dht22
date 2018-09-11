# DHT: loldht and dht library

Driver for DHT22/AM2302 Temperature and humidity sensors on Raspberry Pi.
Based on dht11.c: http://ubuntuone.com/6mT9cTREz90BUfvQD1AGNy (license unknown).
Requires wiringPi library.

./configure
make
sudo ./loldht
Raspberry Pi wiringPi DHT11 Temperature test program
Humidity = 42.90 % Temperature = 22.20 *C

License: Public domain. Do what you want. No warranties.

./configure options:
 --disable-silent-rules Show the make process (silent by default)
 --disable-secure Disable compile with FORTIY_SOURCE and stack-protector (enabled by default)
 --enable-development Compile with -g -O0 -Wall. Applies disable-secure automatically

autogen.sh: Autoconf boostrap. Development use only.

## Additional stuff by Tobias Ebert
* Shared library support: Create shared library named libdht.so by calling _compile_shared_library.sh
* Using library in C#/.NET Applications: Call _compile_mono.sh and _run_mono.sh
