from turtle import *
speed(-1)

colors = ['red', 'blue', 'brown', 'yellow', 'grey']
n = 3

for a in range(len(colors)):
        color(colors[a-3])
        for i in range(n):
                forward(100)
                left(360/n)
        n += 1

