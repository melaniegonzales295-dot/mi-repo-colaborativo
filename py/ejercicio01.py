#Alquiler (precios unitarios)
hab=int(input("Ingresar cantidad de habitaciones: "))
banno=int(input("Ingresar cantidad de baños: "))
patio=int(input("Ingresar cantidad de patios: "))

monto_total = (hab*30)+(banno*10)+(patio*15)

print(f"Monto total a pagar: {monto_total}")