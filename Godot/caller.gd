extends Node3D
@export var Receiver: Node3D

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
		print ("hello friend")
		Receiver.OnCalled()


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass
