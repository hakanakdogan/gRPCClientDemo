using Grpc.Net.Client;
using gRPCClientDemo;


var data = new OrderRequest { OrderId = 1 };
var grpcChannel = GrpcChannel.ForAddress("https://localhost:7016");
var client = new OrderProcessing.OrderProcessingClient(grpcChannel);
var response = await client.GetOrderAsync(data);
Console.WriteLine("Order Quantity: {0}", response.Order.OrderQuantity);
Console.ReadLine();
