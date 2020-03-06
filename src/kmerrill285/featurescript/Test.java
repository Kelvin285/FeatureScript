package kmerrill285.featurescript;


import kmerrill285.featurescript.scripts.objects.Script;

public class Test {

	public static void main(String[] args) {
		FeatureScript.load("features");
		
		
		
		for (String str : FeatureScript.scripts.keySet()) {
			Script script = FeatureScript.scripts.get(str);
		}
	}

}
