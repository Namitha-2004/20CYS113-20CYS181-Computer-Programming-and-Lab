print("Please enter your roll number (The last two digits only)")
rollno = int(input())
print("Please enter your Name ")
name = input()
print("Please enter your Address in sigle line ")
address = input()
print("Please enter your Blood group")
bloodgrp = input()
print("Please enter your Phone Number (if any code begin with 00---)")
pnum = int(input())
print("Please enter your Department to which you have assigned")
department = input()
print("Student Info")
print("The Roll number of the student is " + str(rollno) + " The Name of the student is " + name + " The Adress of the student is " + address + " The Blood group of the student is " + bloodgrp + " The Phone Number of the student is " + str(pnum) + " The Department of the student is " + department)
print("Enter the Semester")
sem = int(input())
print("Enter the subject code")
subjectcode = input()
print("Enter the periodical 1 marks")
p1 = float(input())
print("Enter the periodical 2 marks")
p2 = float(input())
print("Enter the Final Exam marks")
final = float(input())
total = p1 + p2 + final
avg = total / 3
print("The roll number of student is " + str(rollno) + " The subject code here is " + subjectcode + " The total marks of student is " + str(total) + " The average of the student is " + str(avg))
