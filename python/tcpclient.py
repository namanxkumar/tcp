import socket

class TCPClient:
    def __init__(self, ip, port) -> None:
        self.ip = ip
        self.port = port
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.clients = []

    def connect(self):
        print(f"Connecting to {self.ip}:{self.port}")
        self.sock.connect((self.ip, self.port))

    def loop(self):
        try:
            while 1:
                message = input('Enter a message to send to the server (or "quit" to exit): ')
                if message == 'quit':
                    break
                self.sock.sendall(bytes(message, 'utf-8'))

                # Receive data from the server and print it
                data = self.sock.recv(1024)
                print('received {!r}'.format(data))
        finally:
            print("Closing")
            self.sock.close()

if __name__ == "__main__":
    server = TCPClient('127.0.0.1', 9000)
    server.connect()
    server.loop()