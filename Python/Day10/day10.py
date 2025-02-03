import csv

# Data to write
data = [
    ["Name", "Age", "City"],  # Header row
    ["Alice", 25, "New York"],
    ["Bob", 30, "Los Angeles"],
    ["Charlie", 22, "Chicago"],
    ["Charli", 2 , "Chicag"]
]

# Writing to a CSV file
with open("people.csv", "w", newline="") as file:
    writer = csv.writer(file)
    writer.writerows(data)  # Write multiple rows
