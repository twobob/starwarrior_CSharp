﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis;
using StarWarrior.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StarWarrior.Spatials
{
    class Missile : Spatial
    {
        private Transform transform;

        static Texture2D pixel = null;
	    public Missile(World world, Entity owner) : base(world, owner) {
	    }

	    public override void Initalize() {
		    ComponentMapper transformMapper = new ComponentMapper(typeof(Transform),world.GetEntityManager());
		    transform = transformMapper.Get<Transform>(owner);
	    }

	    public override void Render(SpriteBatch spriteBatch) {
            if (pixel == null)
            {
                pixel = new Texture2D(spriteBatch.GraphicsDevice, 1, 1, true, SurfaceFormat.Color);
            }
		    Rectangle rect = new Rectangle((int)transform.GetX() - 1, (int)transform.GetY() - 3, 2,6);
            spriteBatch.Draw(pixel, rect, Color.White);
	    }
    }
}
