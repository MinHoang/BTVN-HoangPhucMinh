inventory ={
      'gold' : 500,
      'pouch' : ['flint', 'twine', 'gemstone'],
      'backpack' : ['xylophone', 'dagger', 'bedroll', 'bread loaf']
}

inventory['pocket'] = 'seashell','strange berry','lint'
print(inventory)
inventory['backpack'].sort()
print(inventory)
##inventory = {backpack: 'dagger' for backpack,'dagger' in inventory.items() 
##             if 'dagger' != dagger}
inventory["backpack"].remove("dagger")
print(inventory)
inventory['gold'] += 50
print(inventory)


