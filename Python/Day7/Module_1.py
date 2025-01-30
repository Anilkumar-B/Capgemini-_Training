class Order_item:
    def __init__(self,order_id,product_id,quantity,list_price,discount):
        self.order_id=order_id
        self.product_id=product_id
        self.quantity=quantity
        self.list_price=list_price
        self.discount=discount
    def get_total(self):
        return self.quantity*self.list_price*(1-self.discount/100)