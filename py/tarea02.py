precio = float(input("precio unitario (s/.): "))
cantidad = int(input("Cantidad: "))

subtotal = precio * cantidad
igv = subtotal *0.18
total = subtotal + igv

print(f"Subtotal (SIN IGV): S/.{subtotal:.2f}")
print(f"IGV(18%): S/. {igv:.2f}")
print(f"total a pagar: S/{total:.2f}")