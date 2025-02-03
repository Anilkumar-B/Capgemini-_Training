class CSVHandler:
    def init(self,data,filename):
        self.data=data
        self.filename=filename
    def write(self):
        import csv
        csv_file=self.filename
        with open(csv_file,mode="w",newline="") as file:
            writer=csv.DictWriter(file,fieldnames=self.data[0].keys())
            writer.writeheader()
            writer.writerows(self.data)
    def read(self):
        import csv
        csv_file=self.filename
        with open(csv_file,mode="r",newline="") as file:
            reader=csv.DictReader(file)
            for row in reader:
                print(row)
#usage
data=[
    {"name":"shanmuk","age":19},
    {"name":"sai","age":20}
]
csv=CSVHandler(data,"output.csv")
csv.write()
csv.read()