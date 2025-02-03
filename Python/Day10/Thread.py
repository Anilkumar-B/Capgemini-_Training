# import threading #1
# import time #2

# def single_task():
#     print("Taskl started")#5
#     time.sleep(0.9)#6
#     print("Taskl completed")#7


# def task2():
#     print("Verfication is started")
#     time.sleep(3)
#     print("Verification is processing")
#     time.sleep(2)
#     print("Verification is completed")


# t1=threading.Thread(target=single_task)#3
# t1.start()
# t1.join()
# time.sleep(2)
# print(" task1 is completed lets go to verification process")#9
# time.sleep(2)


# t2=threading.Thread(target=task2)#3

# t2.start()
# t2.join()

# time.sleep(2)
# print("Thanks for your patience, you have logged in")



import threading  # (1) Import threading module
import time       # (2) Import time module

def single_task():
    print("Task1 started")  # (5) Prints "Task1 started"
    time.sleep(0.9)         # (6) Sleeps for 0.9 seconds
    print("Task1 completed")  # (7) Prints "Task1 completed"

def task2():
    print("Verification is started")  # Prints "Verification is started"
    time.sleep(3)  # Sleeps for 3 seconds
    print("Verification is processing")  # Prints "Verification is processing"
    time.sleep(2)  # Sleeps for 2 seconds
    print("Verification is completed")  # Prints "Verification is completed"

# Step 1: Start first thread (Task1)
t1 = threading.Thread(target=single_task)  # (3) Create thread
t1.start()  # (4) Start thread execution
t1.join()  # (8) Wait for t1 to finish

time.sleep(2)  # (9) Pause main thread for 2 sec
print("Task1 is completed, let's go to verification process")  # (10) Prints message

time.sleep(2)  # (11) Pause for 2 sec before starting Task2

# Step 2: Start second thread (Task2)
t2 = threading.Thread(target=task2)  # (12) Create thread for verification
t2.start()  # (13) Start verification process
t2.join()  # (14) Wait for verification to finish

time.sleep(2)  # (15) Pause before the final message
print("Thanks for your patience, you have logged in")  # (16) Final message
