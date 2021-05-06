using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasamentiProject
{
    /**
 * Definition of the PlayScreen interface, which extends
 * {@link com.badlogic.gdx.Screen Screen}.
 */
    public interface IPlayScreen 
    {
    /**
     * Setter of the double jump ability.
     * 
     * @param b True if you want to enable it, false otherwise.
     */
    void SetDoubleJumpAbility(bool b);

    /**
     * Add a new life to the player.
     */
    void AddLife();

    /**
     * Remove a life from the player.
     */
    void RemoveLife();

    /**
     * Set the WinScreen.
     */
    void SetWinScreen();

    /**
     * Set the GameOverScreen.
     */
    void SetGameOverScreen();

    /**
     * Set the MenuScreen.
     */
    void SetMenuScreen();

    /**
     * Getter of the ninja X-axis position in the world.
     * 
     * @return The Ninja X-axis float value.
     */
    float GetNinjaXPosition();

    }

}
