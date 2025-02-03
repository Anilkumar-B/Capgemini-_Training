import threading
import time

def task(lock):
    with lock:
        print(f"{threading.current_thread().name} has acquired the lock")
        time.sleep(2)
        print(f"{threading.current_thread().name} has released the lok")
lock=threading.Lock()
t1=threading.Thread( target=task, args= (lock,))
t2=threading.Thread( target=task, args= (lock,))
t1.start()
t2.start()
t1.join()
t2.join()




import threading
import time

def Daemon_task():
    while True:
        print("Daemon thread running...")
        time.sleep(2)
daemon_thread = threading.Thread(target=Daemon_task, daemon=True)
daemon_thread.start()

time.sleep(5)
print("Main thread is running .")
