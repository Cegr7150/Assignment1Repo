extends Node3D
@export var Receiver: Node3D

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
		print ("hello friend")
		Receiver.OnCalled()

var attack_held := false
# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	_attack(delta)
	pass

func _attack(_delta: float) -> void:
	if Input.is_action_just_pressed("Attack"):
		attack_held = true
		print("Attack!!")
