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
