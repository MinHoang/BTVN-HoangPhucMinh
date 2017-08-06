def get_even_list(list_number):
     even_numbers = [number for number in list_number if number%2 == 0]
     print(even_numbers)
     return even_numbers

even_list = get_even_list([1, 2, 5, -10, 9, 6])

if set(even_list) == set([2, -10, 6]):
      print("Your function is correct")
else:
      print("Ooops, bugs detected")


