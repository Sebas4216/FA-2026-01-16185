from email.policy import default
import math
print("------------------- SISTEMA DE CALCULO DE AREA ------------\n")

print("***** MENU DE OPCIONES ******\n")
print("[1]. CUADRADO ")
print("[2]. RECTANGULO ")
print("[3]. TRIANGULO ")
print("[4]. CIRCULO ")
print("*****************************\n")

opc = int(input("ingresar opcion: "))

match opc:
    case 1:
        lado = float(input("Ingrese el lado: "))
        Area = float(lado * lado)
    case 2:
        base = float(input("Ingrese la base: "))
        Altura = float(input("Ingrese la altura: "))
        Area = float(Altura*base)
    case 3:
        base = float(input("Ingrese la base: "))
        Altura = float(input("Ingrese la altura: "))
        Area = float((Altura*base)/2)
    case 4:
        radio = float(input("Ingrese el radio: "))
        Area = math.pi * math.pow(radio,2)
    case _:
        print("Opcion invalida")
print("----- RESULTADO ---------")
print(f"El area es: {Area}")
print("-------------------------")