from turtle import* 
shape("turtle") 
speed(-1)

for n in range(3, 7): 
    #kqua = n % 2 
    if n % 2 == 0: 
        color("red") 
    else: 
        color("blue") 
    for m in range (n): 
        forward(100)  
        left(360/n) 
