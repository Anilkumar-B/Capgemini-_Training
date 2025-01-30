from datetime import date
from customer import Customer
from order import Order, OrderItem
from transaction import Transaction

# Creating a Customer
customer1 = Customer(101, "Anil", "Kumar", 8500404566, "anilkumar@gmail.com", 
                     "KLR Phase 2, Road No. 10", "Medchal", "Hyderabad", 501401)

# Creating an Order
order = Order(101, 1, date.today(), date.today(), None, 10, 5)

# Creating an Order Item and adding it to Order
order_item1 = OrderItem(101, 201, 2, 500, 10)
order.add_item(order_item1)

# Creating a Transaction
transaction1 = Transaction(5001, customer1, order)

# Printing transaction details
details = transaction1.get_transaction_details()
for key, value in details.items():
    print(f"{key}: {value}")
