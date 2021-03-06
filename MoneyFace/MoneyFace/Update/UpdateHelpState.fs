module UpdateHelpState

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Content
open Microsoft.Xna.Framework.Input
open Microsoft.Xna.Framework.Audio
open BoardState
open System
open AssetType
open Assets
open TJoFGDGame
open Constants
open UpdateUtility

let updateHelpState delta (oldKeyboardState:KeyboardState) (oldGamePadState: GamePadState)=
    let keyboardState = Keyboard.GetState()
    let gamePadState = GamePad.GetState(PlayerIndex.One)
    let (keyPresses, buttons) = getInputChanges oldKeyboardState keyboardState oldGamePadState gamePadState
    if keyPresses.Contains(Keys.Escape) || buttons.Contains(Buttons.B) || buttons.Contains(Buttons.Back) then
        TitleScreen (keyboardState,gamePadState)
    else
        HelpState (keyboardState,gamePadState)


