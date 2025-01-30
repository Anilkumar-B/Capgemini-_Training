from datetime import date

class Customer:
    def __init__(self, customer_id, first_name, last_name, phone, email, street, city, state, zip_code):
        self.customer_id = customer_id
        self.first_name = first_name
        self.last_name = last_name
        self.phone = phone
        self.email = email
        self.street = street
        self.city = city
        self.state = state
        self.zip_code = zip_code

    def get_fullname(self):
        return f'{self.first_name} {self.last_name}'

class Order:
    def __init__(self, order_id, order_status, order_date, required_date, shipped_date, store_id, staff_id):
        self.order_id = order_id
        self.order_status = order_status
        self.order_date = order_date
        self.required_date = required_date
        self.shipped_date = shipped_date
        self.store_id = store_id
        self.staff_id = staff_id
        self.items = []

    def add_item(self, item):
        self.items.append(item)

    def get_total_price(self):
        return sum(item.get_total() for item in self.items)

class OrderItem:
    def __init__(self, order_id, product_id, quantity, list_price, discount):
        self.order_id = order_id
        self.product_id = product_id
        self.quantity = quantity
        self.list_price = list_price
        self.discount = discount

    def get_total(self):
        return self.quantity * self.list_price * (1 - self.discount / 100)

class Transaction:
    def __init__(self, transaction_id, customer, order):
        self.transaction_id = transaction_id
        self.customer = customer
        self.order = order

    def get_transaction_details(self):
        return {
            "Transaction ID": self.transaction_id,
            "Customer": self.customer.get_fullname(),
            "Order ID": self.order.order_id,
            "Total Amount": f"${self.order.get_total_price():.2f}",
            "Order Items": [
                {"Product ID": item.product_id, "Quantity": item.quantity, "Price": f"${item.get_total():.2f}"}
                for item in self.order.items
            ]
        }

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
