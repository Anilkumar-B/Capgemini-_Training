# import threading
# data_chunks = [
#     list(range(1, 11)),
#     list(range(11, 21)),
#     list(range(21, 31))
# ]
# def process_data(data):
#     print(f"Processing {data}\n")
#     result = sum(data)
#     print(f"Result: {result}\n")
# threads = []
# for data_chunk in data_chunks:
#     thread = threading.Thread(target=process_data, args=(data_chunk,))
#     threads.append(thread)
#     thread.start()
# for thread in threads:
#     thread.join()


# import threading

# # Define data chunks (Splitting range 1-30 into three chunks)
# data_chunks = [
#     list(range(1, 11)),   # [1, 2, ..., 10]
#     list(range(11, 21)),  # [11, 12, ..., 20]
#     list(range(21, 31))   # [21, 22, ..., 30]
# ]

# def process_data(data):
#     """Function to process a chunk of data (calculate sum)."""
#     print(f"Processing: {data}")
#     result = sum(data)
#     print(f"Result: {result}")

# # Create and start threads
# threads = []
# for data_chunk in data_chunks:
#     thread = threading.Thread(target=process_data, args=(data_chunk,))
#     threads.append(thread)
#     thread.start()

# # Wait for all threads to complete
# for thread in threads:
#     thread.join()

# print("All tasks completed.")

import threading
data_chunks = [
    list(range(1,11)),   
    list(range(11, 21)),  
    list(range(21, 31))   
]

def process_data(data):
    print(f"Processing: {len(data)}")
    result = sum(data)
    print(f"Result: {result}")

for data_chunk in data_chunks:
    thread = threading.Thread(target=process_data, args=(data_chunk,))
    thread.start()
    thread.join() 

print("All tasks completed.")
