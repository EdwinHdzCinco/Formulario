import tkinter as tk
Pantalla = tk.Tk()
Pantalla.title("Hola mundo")
Pantalla.geometry("560x480")
Boton = tk.Button(Pantalla, text= "Hola, mundo",)
Boton.place(x=50,y=50)
Entrada = tk.Entry()
Entrada.place(x = 50,y = 160, width = 300, height= 20)

Pantalla.mainloop()

