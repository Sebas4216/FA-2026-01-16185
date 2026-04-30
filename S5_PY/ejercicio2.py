an = int(input("Ingrese el año: "))
if an % 4 == 0 & an % 100 !=0:
    print ("El año es bisiesto")
else:
    print ("El año no es bisiesto")
if an % 2 == 0:
    print ("es par")
else:
    print("es impar")
    