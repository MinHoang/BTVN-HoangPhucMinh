from turtle import*
speed(-1)

def draw_square(length, colour):
    for i in range(4):
        color(colour)
        forward(length)
        left(90)

for i in range(30):
      draw_square(i * 5, 'red')
      left(17)
      penup()
      forward(i * 2)
      pendown()   

