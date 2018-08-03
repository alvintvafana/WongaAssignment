# WongaAssignment
To run using docker 
==================
Run in your docker cmd

docker run -d --hostname RabbitMQ --name WongaAssignement -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password -e RABBITMQ_DEFAULT_VHOST=vhost -p 4369:4369 -p 5671:5671 -p 5672:5672 -p 15671:15671 -p 15672:15672 rabbitmq:3-management

To run Sender Console
=====================
docker run alvintvafana/rabbitsender -d -name rabbit-sender  -p 5671:5671 -p 5672:5672 

To run Receiver Console
========================
docker run alvintvafana/rabbitreceiver –name rabbit-receiver  -p 5671:5671 -p 5672:5672 
