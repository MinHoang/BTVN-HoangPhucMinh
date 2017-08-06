s_list = []
s_list.append("T-Shirt")
s_list.append("Sweater")

i = input("Welcome to our shop,what would you like to do?")
##while True:
if i == "c":
     ni = input("New item(s)? ")
     s_list.append(ni)
     print("List:",s_list)
elif i == "r":
    print("List: ",s_list)
elif i == "u":
    pos = int(input("Update position? "))
    if pos <= len(s_list):
                new_item = input("Enter new item: ")
                s_list[pos-1] = new_item.capitalize()
                print("List: ",s_list)
    else:
                print("Nope.")

elif i == "d":
    pos = int(input("Delete position? "))
    if pos <= len(s_list):
        s_list.pop(pos-1)
        print("List:",s_list)
    else:
        print("Nope.")

else:
    print("There's No Such Thing.")
    
        
