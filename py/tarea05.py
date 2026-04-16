import math
monto=float(input("monto en soles: "))
hacia_arriba=math.ceil(monto)
hacia_abajo=math.floor(monto)
truncado=int(monto)
redondeado = round(monto,2)

print(f"Monto original:           {monto}")
print(f"Ceiling(hacia arriba):    {hacia_arriba}")
print(f"floor (hacia abajo):      {hacia_abajo}")
print(f" Truncado (int)           {truncado}")
print(f"Redondeado (2 decimales) {redondeado}")
