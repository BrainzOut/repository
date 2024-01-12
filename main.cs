namespace ConsoleApp1 {
	class Programm {
		public static void Test(object x, object y) {
			if (x.Equals(y)) {
				Console.WriteLine("No problem!");
			} else {
				Console.WriteLine("SOS!");
			}
		}
		static void Main(string[] args) {
			Console.WriteLine("Hey! It's my first app in C#. So don't be soo stringent. (> _ <)");

			Vehicle testVehicle = new(12345, "truck", 300);
			Order testOrder = new(123, "From Russia to Uzbekistan!");
			Manager testManager = new(1234, 12345, "truck");
			User testUser = new(12, "+9313432");

			// class Vehicle
			Test(testVehicle.id, 12345);
			Test(testVehicle.maxWeight, 300);
			Test(testVehicle.Honk(2), "Beep! Beep! ");

			// class Order
			Test(testOrder.description, "From Russia to Uzbekistan!");
			testOrder.RateOrder(testManager, 4.5);
			Test(testManager.rating, 4.5);

			// class Manager
			Test(testManager.vehicleId, testVehicle.id);
			testManager.GetOrder(testOrder);
			Test(testOrder.state, "in process");
			testManager.CloseOrder(testOrder);
			Test(testOrder.state, "closed");

			// class User
			Test(testUser.id, 12);
			testUser.CreateOrder();
			testUser.ChangeOrderState(testOrder, "open");
			Test(testOrder.state, "open");
		}
	}
	class Vehicle {
		public int id;
		public int maxWeight; //kg
		public String type;
		public String regNum;
		public Color color;

		public int ownerId;
		public String Honk(int times) {
			int n = 0;
			String str = "";

			while (n != times) {
				str += "Beep! ";
				n++;
			}
			return str;
		}

		public void Move(int km) {
			Console.WriteLine("Vehicle moved " + km + " km.");
		}
		public Vehicle() {
			id = -1;
			type = "";
			maxWeight = -1;
			regNum = "";
			color = Color.White;

			ownerId = -1;
		}
		public Vehicle(int id, String type) {
			this.id = id;
			this.type = type;
		}
		public Vehicle(int id, String type, int maxWeight) {
			this.id = id;
			this.type = type;
			this.maxWeight = maxWeight;
		}
	};

	class Order {
		public int id;
		public int userId;
		public int managerId;
		public int vehicleId;
		public String description;
		public String state;

		public void RateOrder(Manager manager, double rating) {
			manager.rating = rating;
		}

		public Order() {
			id = -1;
			userId = -1;
			managerId = -1;
			vehicleId = -1;
			description = "";
			state = "closed";
		}

		public Order(int id, String description) {
			this.id = id;
			this.description = description;
		}
	};

	class Manager {
		public int id;
		public double rating;
		public bool state;
		public String fullname;
		public String drLicense;

		public int vehicleId;
		public String vehicleType;

		public String SayThis(String str) {
			return str;
		}

		public void CheckState(bool state) {
			if (state == true) {
				Console.WriteLine("Ready to accept your order!");
			} else {
				Console.WriteLine("Driver is busy!");
			}
		}

		public void GetOrder(Order order) {
			order.state = "in process";
			Console.WriteLine(order.id + " order in process!");
		}
		public void CloseOrder(Order order) {
			order.state = "closed";
			Console.WriteLine(order.id + " order is closed! You can rate the manager!");
		}

		public Manager() {
			id = -1;
			fullname = string.Empty;
			drLicense = string.Empty;
			state = true;
			rating = 0;

			vehicleId = -1;
			vehicleType = string.Empty;
		}

		public Manager(int id, int vehicleId, String vehicleType) {
			this.id = id;
			this.vehicleId = vehicleId;
			this.vehicleType = vehicleType;
		}
	};

	class User {
		public int id;
		public String name;
		public String surname;
		public String phone;
		public void CreateOrder() {
			Order order = new();
			Random random = new();

			order.id = random.Next(0, 100);

			order.state = "open";
			Console.WriteLine("Order with id {" + order.id + "} was created successfully!");
		}
		public void ChangeOrderState(Order order, String newState) {
			order.state = newState;
		}

		public User() {
			id = -1;
			name = "";
			surname = "";
			phone = "";
		}
		public User(int id, String phone) {
			this.id = id;
			this.phone = phone;
		}
	};
}