# WongaAssignment
To run using docker 
==================
Run in your docker cmd

docker run -d --hostname RabbitMQ --name WongaAssignement -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password -e RABBITMQ_DEFAULT_VHOST=vhost -p 4369:4369 -p 5671:5671 -p 5672:5672 -p 15671:15671 -p 15672:15672 rabbitmq:3-management

To run Sender Console
=====================
docker run rabbitsender -d -name alvintvafana/rabbitsender -p 5671:5671 -p 5672:5672 

To run Receiver Console
========================
docker run rabbitreceiver –name alvintvafana/rabbitreceiver  -p 5671:5671 -p 5672:5672 


Pattern Used
===========
For the receiver the observor pattern was used and the RabbitMQ, class was made a subject to notify our console class when ever a new message comes along.

