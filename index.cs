extends RigidBody2D

func _ready():
	$AnimatedSprite2D.play()
	var mob_types = Array($AnimatedSprite2D.sprite_frames.get_animation_names())
	$AnimatedSprite2D.animation = mob_types.pick_random()


func _on_VisibilityNotifier2D_screen_exited():
	queue_free()

/*
XCOM 2
Monster Hunter

"Any game where the misson-based gameplay leads you to building up and improving a base or a community. MGSV's gameplay, MGS Peace Walker, Xenoblade Torna are games that recently had this deal going for them and I couldn't get enough of them"
    The most dissapointing example of this were elements of Dragon age: Inqisition. Sure, you get to "slightly" expand your sky keep (or whatever it's called), but the fact that I couldn't repeair the hole in the wall was SUCH a huge letdown :) The first thing I thought to myself when seeing this (after I knew the improving base is in fact a game mechanic): I can't wait till I fix this hole.
Of course this is a nitpick, because the game is hella fun to play."

    XCOM 2 had that for me. I’ll stop after this mission. I’ll stop before the next mission. I’ll stop after this mission. I’ll stop before the next mission. All night."

"I have two that get me every time.

    1. Games like XCOM where you send out a squad, do a mission, come back, heal, build, train, repeat. It's just very satisfying for me.

    2. Monster Hunter. Go out, hunt a monster. Use its parts to make better gear so you can go hunt a bigger monster so you can get better gear so you can hunt a bigger monster. Continue forever."
*/