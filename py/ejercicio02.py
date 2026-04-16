energy=int(input("Ingresar la cantidad de energía consumida(kwh)"))
sub_total= 5+(energy*0.55)
igv= sub_total*0.18
total= igv+ sub_total
print(f"Subtotal: {sub_total}")
print(f"IGV: {igv}")
print(f"Total: {total}")