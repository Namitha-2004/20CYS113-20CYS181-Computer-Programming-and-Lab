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

# Main
print("Please enter the n value for which factorial need to be found")
n = int(input())
answer = factorial(n)
