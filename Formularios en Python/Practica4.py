import tkinter as tk
app = tk.Tk()
app.title("Conversor de temperatura")

label1 = tk.Label(app, text = "Fahrenheit:")
label1.grid(row = 0, column = 0)

entry1 = tk.Entry(app)
entry1.grid(row = 0, column = 1)

buton1 = tk.Button(app,text = "Convertir a Fahrenheit")
buton1.grid(row = 0, column = 2)

label2 = tk.Label(app, text = "Celsius:")
label2.grid(row = 1, column = 0)

entry2 = tk.Entry(app)
entry2.grid(row = 1, column = 1)

buton2 = tk.Button(app,text = "Convertir a celsius")
buton2.grid(row = 1, column = 2)

buton3 = tk.Button(app, text = "Restablecer")
buton3.grid(row = 2, column = 1)

app.geometry("350x150")

app.mainloop()

def reset():
    entry1.delete(0,tk.END)
    entry1.insert(0, "0,0")
    entry2.delete(0,tk.END)
    entry2.insert(0, "0,0")
    
def convert_to_fahrenheit():
    celsius = float(entry2.get())
    fahrenheit = (celsius * 9 / 5) + 32
    entry1.delete(0,tk.END)
    entry1.insert(0, f"{fahrenheit:.2f}")
    
def convert_to_celsius():
    fahrenheit = float(entry1.get())
    celsius= (fahrenheit - 32) * 5.0 / 9.0
    entry2.delete(0,tk.END)
    entry2.insert(0, f"{celsius:.2f}")


