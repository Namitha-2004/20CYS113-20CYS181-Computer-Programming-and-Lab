def deposit(balance):
    print("Please enter the amount to be deposited")
    deposit = float(input())
    print("You have successfully deposited " + str(deposit) + " Rs to your account")
    deposit = balance + deposit
    print("The remaninning balance in your account is " + str(deposit))
    
    return deposit

def recommend(balance):
    print("Please enter the number to which you have recommended the bank")
    var_return = float(input())
    print("You have successfully Recommended " + str(var_return) + " to our bank. As agift you will have certain priviledges")
    var_return = balance + var_return * 50
    print("The remaninning balance in your account is " + str(var_return))
    
    return var_return

def withdraw(balance):
    print("Please enter the amount to be withdrawed")
    withdraw = float(input())
    if withdraw < balance:
        if balance > 500:
            print("You have successfully withdrawed " + str(withdraw) + " Rs from your account")
            withdraw = balance - withdraw
        else:
            if balance == 500:
                print("Please add more amount to your account")
                print("You have successfully withdrawed " + str(withdraw) + " Rs from your account")
                withdraw = balance - withdraw
            else:
                print("You cant withdraw from your account due to unsufficient balance")
                withdraw = balance
        print("The remaninning balance in your account is " + str(withdraw))
    else:
        print("You have given a greater amount than in your account , So you cant withdraw the money ")
        print("The remaninning balance in your account is " + str(balance))
    
    return withdraw

# Main
print("Enter the number of users ")
n = int(input())
balance = [0] * (n)

i = 0
j = 1
while i <= n - 1:
    print("Please enter the balance amount of user " + str(j))
    value = float(input())
    balance[i] = value
    i = i + 1
    j = j + 1
print("Please enter the user which need access")
userchoice = int(input())
useramo = balance[userchoice - 1]
print("Please enter choice as 1 for withdraw of money ")
print("Please enter choice as 2 for deposition of money ")
print("Please enter choice as 3 for recommending")
choice = int(input())
if choice == 1:
    withdrawres = withdraw(useramo)
    balance[userchoice - 1] = withdrawres
else:
    if choice == 2:
        depositres = deposit(useramo)
        balance[userchoice - 1] = depositres
    else:
        if choice == 3:
            recres = recommend(useramo)
            balance[userchoice - 1] = recres
        else:
            print("You have entered the wrong output")
