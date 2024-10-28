# For Part A: "Contrast the case-sensitivty in Java and Python"

# In Python names are case sensitive and follow a rule set of any char is allowed as long as it is a letter (uppercase or lowercase are different chars so A != a), a number ( 0 - 9 ),
# or and underscore _ , the variable name cannot start with a number, and you cannot use reserved words ( such as class, int, static, public, private, etc...). 
# So CustomerMoney and customerMoney are not the same variable. The only difference of caseSensitivity in Python from Java is the non use of a money sign $ in var naming for Python.

customerMoney = 10
CustomerMoney = 50

print("customerMoney = ", 10)
print("CustomerMoney = ", CustomerMoney)

