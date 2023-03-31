def year1(pri1):
    totval = pri1 + pri1 * 0.03
    
    return totval

def year2(prival):
    totval = prival + prival * 0.04
    
    return totval

def year3(pri3):
    totval = pri3 + pri3 * 0.05
    
    return totval

def year4(pri4):
    totval = pri4 + pri4 * 0.055
    
    return totval

def year5(pri5):
    totval = pri5 + pri5 * 0.06
    
    return totval

# Main
print("Enter the number of users ")
n = int(input())
principle = [0] * (n)
year = [0] * (n)

i = 0
j = 1
while i <= n - 1:
    print("Please enter the principle amount of user " + str(j))
    value = float(input())
    principle[i] = value
    print("Please enter the year")
    years = int(input())
    year[i] = years
    i = i + 1
    j = j + 1
print("Please enter the user which need access")
userchoice = int(input())
useramo = principle[userchoice - 1]
choice = year[userchoice - 1]
if choice == 1:
    fixedval = year1(useramo)
else:
    if choice == 2:
        useramo = useramo + year1(useramo)
        fixedval = year2(useramo)
    else:
        if choice == 3:
            useramo = useramo + year1(useramo) + year2(useramo)
            fixedval = year3(useramo)
        else:
            if choice == 4:
                useramo = useramo + year1(useramo) + year2(useramo) + year3(useramo)
                fixedval = year4(useramo)
            else:
                if choice >= 5:
                    useramo = useramo + year1(useramo) + year2(useramo) + year3(useramo) + year4(useramo)
                    fixedval = year5(useramo)
                else:
                    print("You have entered the number of year")
print("The final fixed deposit amount is " + str(fixedval))
