#pragma strict
 
///Variables Declaration///
var target : Transform;
public var enemy : GameObject;
public var player : GameObject;
private var range : float;
var speed : float;
  
///Fixed Update///
function FixedUpdate ()
{
    //Vector2.Distance = enemy.transform.position - player.transform.position
    range = Vector2.Distance(enemy.transform.position, player.transform.position);

    transform.Translate(Vector2.MoveTowards(enemy.transform.position, player.transform.position, range) * speed * Time.deltaTime);
}