#include <stdio.h>

int main(void)
{
	char nombre[4];
	int entero1, entero2;
	float decimal;

	printf("Introduce tu nombre: \n");
	scanf("%s", nombre);
	printf("Te llamas %s", nombre);
	return 0;
}