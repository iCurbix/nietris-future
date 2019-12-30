﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class IPiece : Tetromino
    {
        public override char? PieceSymbol() { return 'i'; }
        public override List<Vector2> StartingPosition() { return new List<Vector2> { new Vector2(3, -1), new Vector2(4, -1), new Vector2(5, -1), new Vector2(6, -1) }; }


        public override List<Vector2> Rotate(List<Vector2> current, rotations currentRotation, rotationDirection direction, ref char?[,] array)
        {
            int maxX = 0;
            int minX = 10;
            float centerX;
            int maxY = -5;
            int minY = 20;
            float centerY;
            foreach (Vector2 v in current)
            {
                if (v.X > maxX) maxX = (int)v.X;
                if (v.X < minX) minX = (int)v.X;
                if (v.Y > maxY) maxY = (int)v.Y;
                if (v.Y < minY) minY = (int)v.Y;
            }
            centerX = (minX + maxX) / 2;
            centerY = (minY + maxY) / 2;

            if(currentRotation == rotations.rotation1 && direction == rotationDirection.clockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 1.5f, centerY + 2), new Vector2(centerX + 1.5f, centerY + 1), new Vector2(centerX + 1.5f, centerY), new Vector2(centerX + 1.5f, centerY - 1) };
            }
            if (currentRotation == rotations.rotation1 && direction == rotationDirection.counterclockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 0.5f, centerY + 2), new Vector2(centerX + 0.5f, centerY + 1), new Vector2(centerX + 0.5f, centerY), new Vector2(centerX + 0.5f, centerY - 1) };
            }

            if (currentRotation == rotations.rotation2 && direction == rotationDirection.clockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 1, centerY + 1.5f), new Vector2(centerX , centerY + 1.5f), new Vector2(centerX -1, centerY + 1.5f), new Vector2(centerX - 2, centerY + 1.5f) };
            }
            if (currentRotation == rotations.rotation2 && direction == rotationDirection.counterclockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 1, centerY + 0.5f), new Vector2(centerX, centerY + 0.5f), new Vector2(centerX - 1, centerY + 0.5f), new Vector2(centerX - 2, centerY + 0.5f) };
            }

            if (currentRotation == rotations.rotation3 && direction == rotationDirection.clockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 0.5f, centerY + 1), new Vector2(centerX + 0.5f, centerY), new Vector2(centerX + 0.5f, centerY - 1), new Vector2(centerX + 0.5f, centerY - 2) };
            }
            if (currentRotation == rotations.rotation3 && direction == rotationDirection.counterclockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 1.5f, centerY + 1), new Vector2(centerX + 1.5f, centerY), new Vector2(centerX + 1.5f, centerY - 1), new Vector2(centerX + 1.5f, centerY - 2) };
            }

            if (currentRotation == rotations.rotation4 && direction == rotationDirection.clockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 2, centerY + 0.5f), new Vector2(centerX + 1, centerY + 0.5f), new Vector2(centerX, centerY + 0.5f), new Vector2(centerX - 1, centerY + 0.5f) };
            }
            if (currentRotation == rotations.rotation4 && direction == rotationDirection.counterclockwise)
            {
                return new List<Vector2> { new Vector2(centerX + 2, centerY + 1.5f), new Vector2(centerX + 1, centerY + 1.5f), new Vector2(centerX, centerY + 1.5f), new Vector2(centerX - 1, centerY + 1.5f) };
            }

            return current;

        }
    }
}
