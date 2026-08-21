def sumar(num1, num2):
    return num1 + num2

def restar(num1, num2):
    return num1 - num2

def multiplicar(num1, num2):
    return num1 * num2    

def dividir(num1, num2):
    if (num2 == 0):
        return "No se puede dividir entre 0"
    else:
        return num1 / num2


def main():
    num1 = 48
    num2 = 4

    print(sumar(num1, num2))
    print(restar(num1, num2))
    print(multiplicar(num1, num2))
    print(dividir(num1, num2))

if __name__ == "__main__":
    main()
