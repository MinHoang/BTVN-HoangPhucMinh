prices = {"Banana": 4,
         "Apple": 2,
         "Orange": 1.5,
         "Pear": 3
      }

p_items = ["Banana", 5, "Apple", 6, "Orange", 3, "Pear", 4]
Total=0

for i in range(len(p_items)):
    item = p_items[i]
    if i%2 == 0:
        price = prices[item]
        print(item,": Amount(s):",p_items[i+1], ": Price:",price)
        cost= p_items[i+1]*price
        Total += cost

print("Your total cost is only: ",Total)
 
