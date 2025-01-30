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
