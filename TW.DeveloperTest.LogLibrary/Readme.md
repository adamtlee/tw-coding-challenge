# Logger Library

The Logger class is a simple implementation of the ILogger interface. This logger provides two methods, LogInfo and LogError, to log informational and error messages to the console with a timestamp.

The LogInfo method logs an informational message to the console, including a timestamp with format yyyy-MM-dd HH:mm:ss.fff. It takes in a single parameter message, which is the message to be logged.

The LogError method logs an error message to the console, optionally including the details of an exception. It takes in two parameters, message and ex. message is the message to be logged, while ex is an optional parameter that represents the exception that caused the error. If ex is provided, the method will append the exception message to the error message that is logged.