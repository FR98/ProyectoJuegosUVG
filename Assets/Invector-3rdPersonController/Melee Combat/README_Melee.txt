Thank you for support our asset!

*IMPORTANT* This asset requires Unity 5.5.1 or higher.

If you have any question about how it works or if you are experiencing any trouble, 
feel free to email us at: inv3ctor@gmail.com
Please do not Upload or share this asset as a package without permission.

If you downloaded this asset illegally for studies or prototype purposes, 
please reconsider purchase if you want to publish your work, you can buy on the AssetStore, the vStore
or send us a email and we can figure something out, you can even post your work on our Forum, 
will be happy to help and advertise your game.

It has been more than 1 year since the release of v1.0 and we continue to work on this only because of your support, 
otherwise we will have to find day jobs and we would never had time to work on this, so thank you!

ASSETSTORE: https://www.assetstore.unity3d.com/en/#!/content/44227
VSTORE: https://sellfy.com/invector
FORUM: http://invector.proboards.com/
YOUTUBE: https://www.youtube.com/channel/UCSEoY03WFn7D0m1uMi6DxZQ
WEBSITE: http://www.invector.xyz/
PATREON: https://www.patreon.com/invector

Invector Team - 2018

MeleeCombat v2.2.5 ANIMATOR UPDATE - 09/01/2017

* Happy New Year!!

- add leaning animations for walk, run and sprint animations
- add new unarmed moveset for free, strafe and crouch 
- add new pick up item animations
- add SetLockShooterInput, SetLockMeleeInput and SetLockBasicInput to call on Events and lock individual inputs
- add ShowCursor, LockCursor and SetLockCameraInput methods to call on Events
- add new CheckGroundMethod with options to Low and High detections levels
- add new 2.5 with path and camera triggers demo scene for BasicLocomotion
- updated vPlatform to work with the FreeClimb Add-on
- updated all animator controllers (*important - make sure to update your old animator based on the new)
- fixed camera bugs
- fixed bug animations looping on 2017.3

-----------------------------------------------------------------------------------------------------

MeleeCombat v2.2.4 HOTFIX - 31/10/2017

- changes in the tpInput to update the Adventure Creator & Playmaker Integration
- slopeLimit improved and add slide velocity in the inspector
- fix bugs in the 2.5D scene, player animator needs to be on update mode animatePhysics
- fix lock-on target not exiting lock-on mode with more then 1 target close

-----------------------------------------------------------------------------------------------------

MeleeCombat v2.2.3 HOTFIX - 05/10/2017

- fix onDead event not being called on vCharacterStandalone
- fix ragdoll RemovePhysicsAfterDie option
- fix ragdoll causing error when dying on spikes
- fix weapon holder bug (when pickup a new weapon, the current weapon holder show/hide)

-----------------------------------------------------------------------------------------------------

MeleeCombat v2.2.2 HOTFIX - 18/09/2017

- add support to quickly change the CameraState using the ChangeCameraState method from tpInput
- add support to create Ragdolls for Generic Rigs 
- add Ragdoll Generic Template if you have several models with the same hierarchy name, add the bone name once and create for every model
- fix weapon handler equip delay time
- fix roll direction bug when using strafe
- fix strafeLimit not working when walkByDefault is enable
- change animator update mode back to normal 
- change ColorSpace back to Gama (default color space of Unity)
- minor improvements 

-----------------------------------------------------------------------------------------------------

MeleeCombat v2.2.1 HOTFIX- 30/08/2017

- fix strafe movement speed 
- fix melee manager not causing any damage on generic custom hitboxes
- fix camera jittering when using the MeleeLockOn
- fix katana 3D Model importing errors on 5.5.0
- fix speed of holding melee weapons walk animations
- fix mobile inventory not equiping weapons
- add free movement with lockOn (use the bool strafeWhileLockOn) 
- add API link under the tab Help

-----------------------------------------------------------------------------------------------------

MeleeCombat v2.2.0 TOPDOWN/2.5D- 17/08/2017

- add 2.5D Curved path system
- add camera trigger to change angle
- add Topdown movement with rotation based on mousePosition 
- add LockMeleeInput option to use with events (see topdown example)
- remove ClickToMove from the Core, now different types of controller have their own scripts making the core more clean
- change the GenericAnimation to have a external way to call the method PlayAnimation without input
- improved aim IK behaviour smoothness
- improved camera behaviour smoothness
- improved charater rotation smoothness
- fix Camera StartUsingTransformRotation and StartSmooth options
- fix footstep particle instantiating without layer verification
- fix stamina consumption while crouching or jumping

------------------------------------------------------------------------------------------------------

MeleeCombat v2.2d HOTFIX UPDATE - 19/07/2017

- add katana 2 hand moveset & attack animations 
- add revival option for both Player & AI
- add new inspector icons for important scripts
- change move speed variables to a internal class 
- creating a melee controller now adds the meleeManager and lock-on automatically
- footstep has the defaultSurface assign when add the component
- fix reaction/recoil/death animations playing without root motion
- fix ragdoll bug disappearing the character after the 2 hit
- fix mouse click not working in the inventory on editor
- fix/improved turnOnSpot verifications

-----------------------------------------------------------------------------------------------------

Changelog v2.2c IMPROVEMENTS UPDATE - 30/6/2017

- add inventory support for Mobile
- add Inventory DemoScene with examples on how to add/remove/equip/unequip/destroy/drop/check items
- add vItemCollectionDisplay prefab (hud text showing what you collect from the vItemCollection)
- add keycard examples to open doors
- add support to revive the Player 
- add option to remove components when the player dies
- add option to start the camera without the player rotation and without lerp
- add input to go up/down for the ladder
- fixed StepOffset Raycast interfering with Triggers making the character float a little bit 
- fixed headtrack look at while aiming bug
- new small features for the scene 2.5D, lock Z axis and remove vertical input
- the Lock-On component is now a add-on and should be attached into the Player instead of the Camera
- improved FootStep logic
- remove all SendMessage calls from the project
- several small fixes and improvements requested by add-on creators to improve compatibility
- controller is now setup to be without root motion by default, to improve the range of adding new custom animations

-----------------------------------------------------------------------------------------------------

Changelog v2.2b HOTFIX/INVENTORY - 5/6/2017

- updated documentation
- improved ladder action component
- improved jump animation transition
- add strong unarmed attack animations
- add option to auto equip melee weapons, and set the equiArea (melee, consumable, etc) 
- add SlotIdentifier on the EquipDisplay so it's easier to know what slot you're in
- fix chests in the melee demo scene
- fix occasionally 360 camera spin after enemy die with lock-on activated
- fix weapon holders bugs 

-----------------------------------------------------------------------------------------------------

Changelog v2.2a HOTFIX - 31/5/2017

- Fix missing BodyMembers in the MeleeManager
- Fix camera reposition to 0, 0, 0 in the Editor
- Add Auto Equip option for the Item & ItemCollection
- Add vRemoveCurrentItem as example to Unequip, Drop or Destroy the current item equipped
- Add vSimpleTrigger script with simple trigger verifications with Events
- Small changes in the vGenericAction 

-----------------------------------------------------------------------------------------------------

Changelog v2.2 ACTION SYSTEM 6/5/2017

- New Action system implemented
- New in-game HUD add 
- New TriggerAction with more options for MatchTarget
- New LadderAction separated from the controller
- New vSkin for the Editors
- Add RandomAttacks example
- Fix Twisted Model on the mobile demo scene
- Fix missing particles prefabs 
- Several minor changes to improve stability

-----------------------------------------------------------------------------------------------------

Changelog v2.1b HOTFIX xx/04/2017

Changes:
- removed all standard assets folders and scripts, use the README at the mobile scene to use the mobile controls
- attack stamina is now deal at the attack state as requested by users
- small changes to improve compatibility with custom add-ons & integrations

-----------------------------------------------------------------------------------------------------

Changelog v2.1a HOTFIX 11/03/2017

Fix: 
- AI not strafing
- auto actions calling the animations twice 
- fix minor issues on every demo scene 
- weapon holder not enabling

Changes:
- changes in the blend tree of the strafe locomotion on the animator 

Add: 
- events for the AI when the state changes

-----------------------------------------------------------------------------------------------------

Changelog v2.1 preShooter 9/03/2017

Fix: 
- AI floating when the capsulle collider is higher then 2f

Changes:
- ItemManager now it's a separated folder to share with the Shooter
- new transition from falling to locomotion, improving the jump transition
- new jump physics
- remove quickStop animation (will be improved in the future)
- new physics material for the player to avoid slide on ramps
- camera improvements and option for sensitivity by state

Add: 
- option to walk by default on free or strafe on the player's inspector
- add turn on spot blend angle animations, optional by bool on inspector
- add new methods to getItems throught code into the ItemManager script
- new demo scene showing auto collectables WITHOUT inventory
- support for Two hand weapon on the inventory
- add option to use attributes and override them to create unique items
- add filter search of ItemType on the ItemManager and ItemCollection
- add option to duplicate items from the ItemListData
- add new window to create attributes as enums in real time
- add option to 'use root-motion' on the player

-----------------------------------------------------------------------------------------------------

Changelog v2.0c smallHOTFIX 11/12/2016

Changes:
- Fix Basic Change Scene buttons
- Minor changes on the 2.5D Scene controller
- Improved JumpMove transition
- Improved TurnOnSpot (add option for moveset)
- Fix Action bug when repeatedly smash the button during an action
- Fix occasionally bug when jumping during an action and falling though the ground
- Fix AI not rolling when 'agressiveAtFirstSight' is true
- DamageObjects now has the option to trigger a reactionID 

-----------------------------------------------------------------------------------------------------

Changelog v2.0b HOTFIX 22/11/2016

Changes:
- Improved rigibody movement using OnAnimatorMove 
- Improved animation transition from CrossFade to CrossFadeInFixedTime 
- Fix bug when hit the button twice or more when starting the action
- Fix jittering while openning the chest on Strafe mode
- Fix MovementSpeed values not working on v2.0a
- Fix vMoveSetSpeed script to handle different moveset ID movement speed separatly
- Fix pendulum prefab missing mesh
- Fix ragdoll reseting at the y = 0 of the world location
- Fix ragdoll creator creating small collider for the head

-----------------------------------------------------------------------------------------------------

Changelog v2.0a HOTFIX 12/11/2016

Changes:
- Fix character locomotion jittering at low frame rates 
- Fix links for youtube tutorials 
- Fix AI not rolling
- Fix AttackName to trigger customParticles
- Fix Player not hitting the CompanionAI
- Fix Enemy not attacking the CompanionAI
- Improved Jump Physics
- Disable V-icon as lockOnSprite in the HUD

-----------------------------------------------------------------------------------------------------

Changelog v2.0 MELEE COMBAT BIG UPDATE 26/10/2016

Changes:
- New MeleeManager
- HeadTrack improved
- Hitbox improved (single or multiple)
- AI Improved (+Performance)
- AI Actions removed (+Performance Boost)
- ThirdPerson & Topdown now share the same scripts, just change the input
- New Collectable system
- ThirdPersonInput & MeleeCombatInput scripts add to handle Input directly
- Changes in the Core of the Controller
- Animator Controller improved
- HUD improved
- New Action verification (+Performance)
- Extra Move Speed improved for the Controller, non-root motion or root motion with extra speed
- Capsule Collider will not be 'stuck' on walls anymore

Add:
- Equip weapons animations
- New Reaction animations by direction (small upperbody / big fullbody)
- New Recoil default animation
- Weapon Holder feature
- Random Weapon for AI
- New CQC animations
- Chest with collectable items & animation 
- Breakable Vases 
- vOnDeadTrigger call a event when the character dies
- New weapon examples
- Consumable items examples (health potion, increase health potion, etc)
- New Reaction animations
- Inventory System 
- Item Manager 
- New MeleeCombat DemoScene
- Events to call when use items (trigger particles, sounds, etc)
- Portal example to change scene with Character, Equiped Weapons & Items

-----------------------------------------------------------------------------------------------------

Changelog v1.3 BASIC LOCOMOTION BIG UPDATE 03/08/2016

Changes:
- Major changes on the main scripts of the Controller
- Improved Jump Physics
- Improved Ragdoll Transitions
- OnTriggerStay improved if using Ragdoll
- TriggerActions method changed, now we check the angle of the trigger instead of using Raycast (+performance)
- DraggableBox removed from the template (we'll remake in the future)

Add:
- New Animator Controller with less transitions, layers & parameters (easier to customize & add new animations)
- New V-bot 2.0 with custom textures and 3 LOD level
- New Headtrack system with LookAt to objects
- Area damage example (damage by frequency when staying inside the area) 
- New Input script that handle all the input separated from the controller (easy to integrate with input assets)
- New Speed by MoveSet script that allow adding different speed values to the locomotion for each moveset 
- Moving platform example
- New Main DemoScene

-----------------------------------------------------------------------------------------------------

Changelog v1.2a HOTFIX 15/06/2016

Fixed:
- GameController Spawning method getting errors or not spawning the Player prefab
- Layer 'Player' not auto-assigning on the Character childrens, making the character auto-crouch when add a Ragdoll
- Wrong stamina consuption at higher FPS 

---------------------------------------------------------

Changelog v1.2 BASIC LOCOMOTION 31/05/2016

Fixed:
- Error when trying to manually add a TPCamera into a Camera
- Wrong stamina consuption in some cases when rolling, jumping and sprint

Changes:
- Controller, Animator & Motor scripts revised with new commends and regions for both Player, easier to use and modify
- Overhall performance improvements 
- Sprint unlock for strafe locomotion, just add the animations into the blendtree

Add:
- Draggable Boxes 
- Dynamic Trigger Action to know if there is a obstacle above or ahead
- Puzzle Boxes Scene showing the new feature
- Add new Beat'n Up Demo Scene
- Tags & Layers are automatically add into the project 
- Health Item example to recover health

---------------------------------------------------------


Changelog v1.1d HOTFIX 17/01/2016
Fixed:
- Character Template missing Animator
 
-----------------------------------------------------------------------------------------------------
 
Changelog v1.1c 12/01/2016
 
Fixed:
- 2 Actions been activate at the same time, causing the Player to glitch between states
 
Changes:
- QuickStop and QuickTurn now are actions and are located in the Action State on the Animator
- Grounded State remade to handle Strafe animations
- Minor changes at the TPMotor, TPAnimator and TPController to prepare the AI on the next update
- Better transition from Strafe to Free locomotion, and the a smoother Quickturn
- ICharacter Interface created to handle the Ragdoll behaviour for both Player and AI
- Improve the verification for quickStop and quickTurn Add:
- Locomotion Type, now you can choose between Strafe Only, Free Only or Free with Strafe
- Crouch Strafe locomotion
- New Layer for Melee 3 Attack Combo, this layers comes without animations at this version,
but we will add some example animations on the next version,
along with the AI
 
-----------------------------------------------------------------------------------------------------

Changelog v1.1b 30/12/2015

Fixed:
- Message displaying change of input between mobile/pc when clicking 
- Fixed the error about bounds on the FootStep when walking between Terrain and Mesh 

Changes:
- TPCamera & HUD isoleted from the controller, now this components are modular and work individually
- Controller now works as a Prefab, can be Instantiated and will automatically find a Camera or the HUD component on the scene
- Culling fade now goes into the character instead of the Camera, also modular just like the Ragdoll of Footstep component.
- Strafe animations re-configured with better transitions
- Several TPCamera improvements of CameraState transitions and Culling 
- Improvements and changes into the TPAnimator and TPMotor, now we separated on methods that controls animations and locomotion behaviour from each other

Add: 
- GameController with SpawnPoint system 
- Non Root-motion movement add, with separated Directional Movement Speed and Strafing Speed
- Rotate by World bool add into the Controller for better locomotion when playing on Isometric Mode
- List of Ignore Tags for the Ragdoll Component, keep Weapons or Acessories that are children of the Player with the correctly rotation
- New Camera Feature - Fixed Point or Multiple Points (Resident Evil oldschool camera's style)
- Trigger System to change CameraPoints
- New Demo Scene with the V Mansion showing the new CameraMode Fixed Point
- Simple Door example

-----------------------------------------------------------------------------------------------------

Changelog HOTFIX v1.1a 10/11/2015

Fix Bugs:
- On the MobileScene the gameObject MobileControls need to be below the HUD gameObject on the Hierarchy (otherwise it will stop respond after the ragdoll turn on)
- Fix the Jump behaviour if you jump right on the edge, the character falls and jump again (mecanim issue)
- Fix the trajectory of the jump in case of high value of height and force forward 
- v1.1 shipped with a aditional XInput plugin, we removed and now you can export Mobile builds normally

Add: 
- The character now can jump while Aiming (just a condition add in the Animator)
- Add 'quick change scene' buttons on the demo scenes
- Add a Camera Fade effect to hide the character when is too close
- Add Clip Plane Margin for better clipping planes to the Camera
- Add InvectorJoystick.cs is just a quickfix to the Square touch area from the CrossPlataformInput to a Circular touch area
- Add the original Standard Assets CrossPlataformInput to improve compatibility with other assets and avoid errors of scripts duplicity
- Add back the AntiAliasing in the Camera

-----------------------------------------------------------------------------------------------------

Changelog v1.1 25/10/2015

Fix Bugs:
- Fix the vibrating upperbody animation when in Aiming mode after the ragdoll was activated (bug found by Chrisb3D, thanks!)
- Fix lockPlayer after roll through the Crouch Area and rarely lock the player on the exit (bug found by tmmandk, thank you sir!)
- Fix minor bug holding shift and enter on Aim mode still drains stamina (reported by Steel Grin, thanks!)

Changes:
- Script "FindTarget" changed to "TriggerAction" and add AutoActions bool
- Major changes on TPCamera script
- Update XInput plugins to the last version with x86 and x86_x64 support
- change CheckForwardAction() and create a CheckActionObject on ThirdPersonMotor
- remove CheckAutoCrouch from the ThirdPersonController and put on ThirdPersonMotor
- improved Culling of the camera 
- improved Ragdoll transition when back to player 
- improved footstep system syncronization
- improved Ground Detection
- now users need to set up layers manually to improve compatibility with others projects

Add:
- Add float spine curvature to set up how much the spine will curve while on Aiming mode
- Add support to realtime change input to Mobile (thanks to Xander Davis)
- Add support to MFi iOS gamepad (thanks to Xander Davis)
- Add Aiming button on Mobile Touch Controls
- Add AutoActions for TriggerActions automatically do an Action without the need of input
- Add Tag for AutoCrouch (use on a simple trigger object)
- Add FootStep support to Play a specific material on objects with multiple materials
- Add feature Jump 
- Add feature Camera Scroll Zoom (Mouse only)
- Add feature FixedAngle on CameraState
- Add DrawGizmos for Debug to verify the Raycasts on Motor (head, actions, stepup, stopmove)
- Add 2.5D Scene Demo
- Add Topdown Scene Demo
- Add Isometric Point&Click Scene Demo