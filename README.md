# decoupled-messaging-demo #

Small example demonstrating the concept of manipulating the JSON in a message directly between various consumers that only know about part of the message.

This prevents any piece of the message being lost due to deserializing into a structure that is missing fields OR being tied into lock-step releases where all consumers must have their message 
structure updated simultaneously.