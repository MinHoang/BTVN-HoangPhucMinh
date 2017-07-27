h = int(input("How tall are you?(In CM) "))/100
w = int(input("How heavy are you?(In KG) "))
bmi = w/h**2

print("Your BMI is: ",bmi)

if bmi < 16:
    print("You Are Abnormally Underweight,Drink Cooking Oil Or Something.")

elif bmi < 18.5:
    print("You're A Tad Bit Thin,Eat Fast Food Or Something.")

elif bmi < 25:
    print("Hey!,You're Normal\nTry To Keep It That Way.")

elif bmi < 30:
    print("You're A Bit Heavy,Nothing A Quick Run In The Morning Wouldn't Fix Though.")

elif 30 < bmi < 50:
    print("You're Too Big,Go To The GYM")

else:
    print("You Need Help.")

