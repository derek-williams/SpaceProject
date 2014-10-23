// The target we are following
var target : Transform;
// The distance in the x-z plane to the target

// Place the script in the Camera-Control group in the component menu
@script AddComponentMenu("Camera-Control/Smooth Follow")


function LateUpdate () {
	// Early out if we don't have a target
	if (!target)
		return;
	
	// Set the position of the camera on the x-z plane to:
	// distance meters behind the target

	
	// Always look at the target
	transform.position.x = target.transform.position.x;
}