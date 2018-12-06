#导入turtle模块
import turtle
window=turtle.Screen()  #创建一个新窗口用于绘图
babbage=turtle.Turtle() #创建一个名字叫babbage的turtle对象
babbage.color("green","black")
babbage.left(90)    #使babbage左转90°
babbage.forward(100)    #向前移动了100像素
babbage.right(90)   #右转90°
babbage.color("black","black")
babbage.begin_fill()    #为圆填充颜色
babbage.circle(10)  #画个半径为10像素的圆
babbage.end_fill()

#画第N个花瓣
for i in range(1,24):
    if babbage.color()==("red","black"):
        babbage.color("orange","black")
    elif babbage.color()==("orange","black"):
        babbage.color("yellow","black")
    else:
          babbage.color("red","black")
    babbage.left(15)
    babbage.forward(50)
    babbage.left(157)
    babbage.forward(50)
babbage.hideturtle()

window.exitonclick()    #定义单击窗口就可以将其关闭
