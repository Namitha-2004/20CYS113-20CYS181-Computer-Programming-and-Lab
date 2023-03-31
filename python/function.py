def factorial(n):
    count = 1
    i = 1
    fact = 1
    print("We are using this function to find factorial")
    if n > 0:
        while count <= n:
            fact = fact * i
            i = i + 1
            count = count + 1
        print("The factorial of the given value is " + str(fact))
    else:
        if n == 0:
            print("The factorial of 0 is " + str(fact))
        else:
            print("Factorial value cant be found for negative numbers")
    
    return fact

def fibo(n):
    print("We are using this function to find Fibonnaci series")
    count = 1
    j = 0
    k = 1
    if n > 0:
        print("The fibonnaci value is 0")
        print("The fibonnaci value is 1")
        while count <= n - 2:
            fvalue = j + k
            j = k
            k = fvalue
            count = count + 1
            print("The fibonnaci value is " + str(fvalue))
    else:
        if n == 0:
            fvalue = 0
            print("The fibonnaci value is 0")
        else:
            fvalue = 0
            print("Fibonacci series cant be found for negative numbers")
    
    return fvalue

def gradesteel(hdn, ccont, tstrength):
    i = 0
    j = 0
    k = 0
    if hdn > 50:
        i = 1
    if ccont < 0.7:
        j = 1
    if tstrength > 5600:
        k = 1
    if i == 1 and j == 1 and k == 1:
        grade = 10
    else:
        if i == 1 and j == 1:
            grade = 9
        else:
            if i == 1 and k == 1:
                grade = 7
            else:
                if j == 1 and k == 1:
                    grade = 8
                else:
                    if i == 1 or j == 1 or k == 1:
                        grade = 6
                    else:
                        grade = 5
    print("The grade of the steel given is " + str(grade))
    
    return grade

# Main
print("Please enter the n value for which factorial need to be found")
n = int(input())
i = 0
j = 1
while i <= n:
    answer = factorial(i)
    i = i + 1
print("Please enter the n value for which fibonnaci need to be found")
p = int(input())
while j <= p:
    answer = fibo(p)
    j = j + 1
count = 1
print("Please enter following values for which grade of the steel need to be found")
print("Please enter the number of steels the grade need to be assigned")
a = int(input())
while count <= a:
    print("Enter the hardness of the steel")
    hnd = float(input())
    print("Enter the carbon content of the steel")
    ccont = float(input())
    print("Enter the tensile strength of the steel")
    tstren = float(input())
    grade = gradesteel(hnd, ccont, tstren)
    count = count + 1
