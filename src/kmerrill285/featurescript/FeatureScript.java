package kmerrill285.featurescript;

import java.io.File;
import java.util.HashMap;

import kmerrill285.featurescript.scripts.objects.Script;

public class FeatureScript {
	public static HashMap<String, Script> scripts = new HashMap<String, Script>();
	public static void load(String directory) {
		try {			
			String external = directory;
			
			startLoad(external);
		} catch (Exception e) {
			e.printStackTrace();
			System.exit(1);
		}
		
	}
	
	private static void startLoad(String directory) {
		load(directory, scripts);
	}
	
	private static void load(String directory, HashMap<String, Script> scripts) {
		File dir = new File(directory);
		if (!dir.exists()) {
			dir.mkdirs();
		}

		File[] files = dir.listFiles();
		if (files != null)
		for (File file : files) {
			Script script = ScriptLoader.loadScript(file.getAbsolutePath());
			System.out.println("Added " + script.name + " feature script\n");
			
			script.run();
			script.executeFunction("init");
			scripts.put(script.name, script);
		}
	}
}
