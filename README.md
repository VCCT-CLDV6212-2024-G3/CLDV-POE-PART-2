Muhammad Rahim
ST10043611
CLDV6212
POE PART 2







![image](https://github.com/user-attachments/assets/f087bca6-7d92-4b7e-a61d-6c7ec314db21)


















Table Of Contents
A)	Integrating Functions to build robust application architecture	3
How To Create Function App	3
How to Publish your VS STUDIO Function Code to your Azure Function App	9
Azure Function Code in VS STUDIO	12
Azure Function App Proof	15
Linking the Two Projects Together.	19
B)	Using services for improving the customer experience	22
1.	Azure Event Hubs	22
2.	Azure Service Bus	23
3.	Combined Benefits of Both Services	24
C)	Links	25
GitHub Link for MVC	25
GitHub Link for Function	25
Web Application	25



















A)	 Integrating Functions to build robust application architecture
How To Create Function App

Step 1: Click on the search bar and look for, “Function App”
 
![image](https://github.com/user-attachments/assets/aad98b16-14f9-415d-b540-32e25347f303)

Step 2: After you click on Function App click on , “Create”.
 

![image](https://github.com/user-attachments/assets/1fdaf902-261a-4cc8-b6a9-3be6e97749d4)



Step 3: Please Click on, “Consumption” Tier then click, “Select” after
 ![image](https://github.com/user-attachments/assets/0ad3ffc1-f1b4-411c-86a4-aee33ab398fa)

Below is all the Different Tiers and what they can do:
Consumption (The One I Chose)
Description: This is a pay-as-you-go model where you only pay for compute resources when your functions are running.
Cost: Lowest cost option since you are only charged for what you use, making it budget friendly.
Scaling: Scales to zero, meaning resources are released when not in use.
Max Scale Out: 200 instances.

Flex Consumption (Preview)
Description: Provides scalability with virtual networking and pay-as-you-go billing but is currently in preview.
Cost: Similar pay-as-you-go billing but offers more flexibility for scaling.
Max Scale Out: 1000 instances.




Functions Premium
Description: Allows multiple function apps to run on the same plan, with event-driven scaling and a minimum of 1 instance always required.
Cost: Higher than Consumption due to reserved capacity.
Max Scale Out: 100 instances.

App Service
Description: Allows you to run web apps and function apps on the same plan with more compute options, requiring a minimum number of instances.
Cost: Higher, as it involves paying for dedicated compute resources.
Max Scale Out: 40-60 instances.

Container Apps Environment
Description: Hosts function apps alongside other microservices in a containerized environment, offering more flexibility for complex setups.
Cost: More expensive, as it involves paying for container compute capacity.
Max Scale Out: 300 instances.
I chose the Consumption plan because it involves the least amount of money, as you only pay for the resources when they are in use, making it a cost-effective option for your needs.










Step 4: Make sure you are using the correct subscription group as well as the resource group. Name your Function App whatever you want it to be I went with my student number. Make sure your Runtime Stack is on .Net, and your Version is on 8 LTS. Make sure for your Region you choose the same region you chose when creating your storage account so that when you go onto step 5 it will display the Storage Account you created in PART 1. Make sure you chose the system that you currently use in my case that is, “Windows”.
 ![image](https://github.com/user-attachments/assets/62afd468-c1bf-4a47-8a2f-a117d6673025)


Step 5: Make sure you choose your storage account you created in PART 1. 
 
![image](https://github.com/user-attachments/assets/eb1428a5-e26a-426d-92b5-b127de6f73d8)


Step 6 Part 1:  Click on, “Deployment” then scroll down to the bottom.
 
![image](https://github.com/user-attachments/assets/acbdb142-315e-487e-9d02-2ce4a7fee615)

Step 6 Part 2: After you scroll down you will see an option underneath Authentication Settings, “Basic Authentication” make sure this is set to enable otherwise you will have problems when it comes to publishing the Function App in Visual Studio.
 

![image](https://github.com/user-attachments/assets/05c9be13-f435-45ca-a61a-3c6ab8b8ca53)



Step 7: If you followed all my steps correctly you can go to the tab that says, “Review + Create” then on the bottom left click on, “Create”. Just like that you have successfully created a Function App in Microsoft Azure.
 




![image](https://github.com/user-attachments/assets/7145ecf5-5a4e-46ba-bbba-75847f0e4d85)





How to Publish your VS STUDIO Function Code to your Azure Function App

Step 1: Click, “Build” then proceed to, “Publish Selection”.
 
![image](https://github.com/user-attachments/assets/ce916c31-f587-479a-85da-cfbd43617539)

Step 2: Click, “Azure” then on, “Next”.
 

![image](https://github.com/user-attachments/assets/766c254e-0a8a-4267-a994-45ae6b84bebd)


Step 3: Choose, “Azure Function App (Windows)” make sure what ever Operating System you chose to create your Function App you chose the same one otherwise it will not find the function app you created in the next step after clicking on, “Next”.
 
![image](https://github.com/user-attachments/assets/5be89129-8bc3-49a4-a526-1f486c133498)

Step 4: Make sure you have the correct, “Subscription Name” in my case its ADvTECH. Then you click on the folder and click on your Function App. Then Click, “Finish”.
 


![image](https://github.com/user-attachments/assets/fb77b3d3-f22d-48db-a11e-b5acdbcffc6f)


Step 5: After you click on, “Finish”  you will see this screen from here click on, “Publish”. If you followed all my steps, you would receive a “Publish Succeeded” message and just like that you have published your code to Azure Function App.
 







![image](https://github.com/user-attachments/assets/1cda45a7-47f2-4b6f-a560-0e3b5d78b3a8)











Azure Function Code in VS STUDIO

Program.cs
 ![image](https://github.com/user-attachments/assets/98094472-787f-4736-b3c7-27e8318bf59d)


HTTPTest.cs
 


![image](https://github.com/user-attachments/assets/d10a2dbe-0ed2-4c87-bac0-ebabc8ad45e7)




ProcessQueueMessage.cs
 ![image](https://github.com/user-attachments/assets/4dea2f66-35e6-41c3-bd25-408305367656)

StoreTableInfo.cs
 ![image](https://github.com/user-attachments/assets/a1182d1c-d0cf-414d-be25-cae63287c50d)

UploadBlob.cs
![image](https://github.com/user-attachments/assets/5836c29c-5b2b-42b8-adf6-a12e8a7d562d)
 

UploadFile.cs
 

![image](https://github.com/user-attachments/assets/e1722173-dcae-4d75-bbc1-ce917c510afc)














Azure Function App Proof
After successfully taking the above code and then following the steps on how to publish and it is successfully published you click the “RUN” button in VS STUDIO, and it will run and execute your commands. If done correctly you will see all the code that you created get POSTED in here and by seeing this, you have successfully sent your Function code to your Azure Function App.
 
![image](https://github.com/user-attachments/assets/f93aba70-bec7-4ee1-8ba7-8af412d785ee)

ProceesQueueMessage Successfully Deployed.
 

![image](https://github.com/user-attachments/assets/811eebf9-014c-4a6c-a3cb-d74d1e70e463)


StoreTableInfo Successfully Deployed.
 ![image](https://github.com/user-attachments/assets/7beaad29-9ae4-4dfc-b19c-6fbd8ff060a7)


UploadBlob Successfully Deployed.
 

![image](https://github.com/user-attachments/assets/570c16a9-5e8d-4482-871f-ac3d5647738b)




UploadFile Successfully Deployed.
 
![image](https://github.com/user-attachments/assets/b7d0dda3-ce2a-409e-a8b4-0106de4b664d)

HTTPTest Successfully Deployed.
 

![image](https://github.com/user-attachments/assets/44b8dd93-e924-428e-aaa8-ee4ddca44000)





Linking the Two Projects Together.
With regards to linking the two so that when I insert data into my web application it sends to both my Azure Storage Account and my Azure Function App, I was only able to get it to go to the storage account but nonetheless here is my code that I attempted to link the two projects and handle the operations

HomeController.cs Part 1.
 
![image](https://github.com/user-attachments/assets/52c7e157-00a4-49ce-a698-d526c8a6422f)

HomeController.cs Part 2.
 

![image](https://github.com/user-attachments/assets/12d600c2-7bb5-4eb8-9b40-09d1e4548d4c)



HomeController.cs Part 3.
 
![image](https://github.com/user-attachments/assets/54c8d8ee-7e6d-4504-ad80-b632225d456f)

HomeController.cs Part 4.
 
![image](https://github.com/user-attachments/assets/d12f99dd-8367-4f02-9110-11932d840243)

HomeController.cs Part 5.
 

![image](https://github.com/user-attachments/assets/694aebea-435a-43a6-99d4-9d221e4c3370)



appsettings.json
 ![image](https://github.com/user-attachments/assets/82cf8655-de6e-4f07-ac20-af111e71c0e7)


Program.cs
 
![image](https://github.com/user-attachments/assets/aaf9cac6-3632-40b6-90f7-869c0ad4d5ad)











B)	 Using services for improving the customer experience
1.	Azure Event Hubs
A)	Description of Service
Real-time data ingestion that is fully managed is provided via Azure Event Hubs. Millions of events per second can be captured and streamed into cloud-based storage or data analysis platforms from any source (applications, devices, sensors, etc.). It is frequently employed in situations like telemetry and huge data pipelines.
B)	Mechanism
Azure Event Hubs gathers data in real time from multiple sources by acting as an event ingester. Scalability is ensured by buffering the events and processing them in real time. Events can keep for batch processing or used in real-time analytics. A great deal of event data can be collected and analyzed thanks to its rapid processing.
•	The Event Hub receives data from Event Producers.
•	Rapid processing is handled by partitions.
•	The data is retrieved for processing by event consumers.
C)	How it Adds Value to End Users
By adding Azure Event Hubs to your application:
•	Real-time Updates: Clients receive alerts with information on changes in real-time, including orders in progress and live data streams.
•	Enhanced Responsiveness: A more flexible and adaptable user interface is the result of real-time event processing, which also enhances user interaction.
•	Data-Driven Personalization: Real-time analysis of user habits and preferences is made possible by continuous data ingestion.






2.	Azure Service Bus
A)	Description of Service
A fully managed business messaging solution called Azure Service Bus is made to facilitate dependable communication between dispersed systems. It enables dependable message queuing in addition to asynchronous messaging, enabling separate application components to operate independently while maintaining safe and effective communication.
B)	Mechanism
Message brokers are used by Azure Service Bus to facilitate interaction among various services or components. Depending on the use case, messages are grouped into a queue or topic so that users can handle them simultaneously. It provides transactional support, duplication detection, and assured message delivery.
•	Messages are sent by producers to a queue or topic.
•	Messages are processed simultaneously by the recipients.
•	Keep in mind Tasks are completed in the correct order with queueing, and in the event of a service outage, nothing is lost.
C)	How it Adds Value to End Users
Your application's use of Azure Service Bus improves the user experience through:
•	Seamless Task Execution: Your app can manage operations in the background without interfering with the user's productivity, even during periods of high traffic, making the user experience more seamless.
•	Reliable Communication: By guaranteeing the processing of vital updates (such as transactions and confirmations), guaranteed delivery builds customer pleasure and trust.
•	Scalability: The application maintains its responsiveness even when it is loaded, effectively managing messages and enhancing performance, particularly in real-time or e-commerce applications.












3.	Combined Benefits of Both Services
You may create a strong and seamless user experience in your application by integrating Azure Event Hubs with Azure Service Bus. For example:
Enhanced Event Processing: Service Bus handles the messaging between different application components, and Event Hubs can handle large amounts of incoming information. A durable and flexible application that may grow in response to requests from users is made possible by this configuration.
Enhanced User Engagement: Users experience an additional engaging user experience when they receive immediate notifications and confirmations without any latency thanks to the combination of real-time insights from Event Hubs and consistent communication from Service Bus.
In summary, by offering scalable solutions, dependable connectivity, and real-time insights, Azure Event Hubs and Azure Service Bus both significantly contribute to improving the user experience. User satisfaction, trust, and engagement can all be considerably increased by implementing them effectively.










C)	 Links
GitHub Link for MVC
GitHub Link for Function
Web Application 




