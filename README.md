# FeatureScript
 An API that allows you to create moddable java programs
=========================
FeatureScript is an interpreted programming language built on top of Javascript 
that can interface directly with java code.
It can be very useful for creating easily moddable content for apps and games written in java.
=========================
Limitations
=========================

1. Only a single instance of a FeatureScript class can be created at one time.
2. FeatureScript does not support multi-line commands
3. FeatureScript functions do not support return types

=========================
Using FeatureScript
=========================

1. The "Init" function acts as a main method and will automatically be called when the
	FeatureScript code is loaded

2. FeatureScript uses JavaScript objects, so you will need to use javascript documentation
	for modifying objects

3. there is an example file included with this project that shows how to use FeatureScript

4. the "FeatureScript" class provides everything needed for loading and executing the code
	
	(static) FeatureScript.load(String directory) -> loads all featurescript code in a folder
						(ignores subdirectories)
	
	(static) FeatureScript.scripts -> HashMap<String, Script> (a HashMap containing all loaded scripts)
	
	
	(non-static) script.executeFunction(String function) -> executes a function in a Script

	(non-static) script.setVariable(String variable, Object value) -> sets a variable in a Script

	(non-static) script.getVariable(String variable) -> gets a variable contained in a Script