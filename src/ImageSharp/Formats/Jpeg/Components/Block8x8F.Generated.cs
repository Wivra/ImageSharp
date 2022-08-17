// Copyright (c) Six Labors.
// Licensed under the Six Labors Split License.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// <auto-generated />
namespace SixLabors.ImageSharp.Formats.Jpeg.Components
{
    internal partial struct Block8x8F
    {
		/// <summary>
        /// Level shift by +maximum/2, clip to [0, maximum]
        /// </summary>
        public void NormalizeColorsInPlace(float maximum)
        {
            var CMin4 = new Vector4(0F);
            var CMax4 = new Vector4(maximum);
            var COff4 = new Vector4(MathF.Ceiling(maximum / 2));

            this.V0L = Numerics.Clamp(this.V0L + COff4, CMin4, CMax4);
            this.V0R = Numerics.Clamp(this.V0R + COff4, CMin4, CMax4);
            this.V1L = Numerics.Clamp(this.V1L + COff4, CMin4, CMax4);
            this.V1R = Numerics.Clamp(this.V1R + COff4, CMin4, CMax4);
            this.V2L = Numerics.Clamp(this.V2L + COff4, CMin4, CMax4);
            this.V2R = Numerics.Clamp(this.V2R + COff4, CMin4, CMax4);
            this.V3L = Numerics.Clamp(this.V3L + COff4, CMin4, CMax4);
            this.V3R = Numerics.Clamp(this.V3R + COff4, CMin4, CMax4);
            this.V4L = Numerics.Clamp(this.V4L + COff4, CMin4, CMax4);
            this.V4R = Numerics.Clamp(this.V4R + COff4, CMin4, CMax4);
            this.V5L = Numerics.Clamp(this.V5L + COff4, CMin4, CMax4);
            this.V5R = Numerics.Clamp(this.V5R + COff4, CMin4, CMax4);
            this.V6L = Numerics.Clamp(this.V6L + COff4, CMin4, CMax4);
            this.V6R = Numerics.Clamp(this.V6R + COff4, CMin4, CMax4);
            this.V7L = Numerics.Clamp(this.V7L + COff4, CMin4, CMax4);
            this.V7R = Numerics.Clamp(this.V7R + COff4, CMin4, CMax4);
        }

        /// <summary>
        /// AVX2-only variant for executing <see cref="NormalizeColorsInPlace"/> and <see cref="RoundInPlace"/> in one step.
        /// </summary>
        [MethodImpl(InliningOptions.ShortMethod)]
        public void NormalizeColorsAndRoundInPlaceVector8(float maximum)
        {
            var off = new Vector<float>(MathF.Ceiling(maximum / 2));
            var max = new Vector<float>(maximum);
            
            ref Vector<float> row0 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V0L);
            row0 = NormalizeAndRound(row0, off, max);
                
            ref Vector<float> row1 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V1L);
            row1 = NormalizeAndRound(row1, off, max);
                
            ref Vector<float> row2 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V2L);
            row2 = NormalizeAndRound(row2, off, max);
                
            ref Vector<float> row3 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V3L);
            row3 = NormalizeAndRound(row3, off, max);
                
            ref Vector<float> row4 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V4L);
            row4 = NormalizeAndRound(row4, off, max);
                
            ref Vector<float> row5 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V5L);
            row5 = NormalizeAndRound(row5, off, max);
                
            ref Vector<float> row6 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V6L);
            row6 = NormalizeAndRound(row6, off, max);
                
            ref Vector<float> row7 = ref Unsafe.As<Vector4, Vector<float>>(ref this.V7L);
            row7 = NormalizeAndRound(row7, off, max);
                
        }

        /// <summary>
        /// Fill the block from 'source' doing short -> float conversion.
        /// </summary>
        public void LoadFromInt16Scalar(ref Block8x8 source)
        {
            ref short selfRef = ref Unsafe.As<Block8x8, short>(ref source);

            this.V0L.X =  Unsafe.Add(ref selfRef, 0);
            this.V0L.Y =  Unsafe.Add(ref selfRef, 1);
            this.V0L.Z =  Unsafe.Add(ref selfRef, 2);
            this.V0L.W =  Unsafe.Add(ref selfRef, 3);
            this.V0R.X =  Unsafe.Add(ref selfRef, 4);
            this.V0R.Y =  Unsafe.Add(ref selfRef, 5);
            this.V0R.Z =  Unsafe.Add(ref selfRef, 6);
            this.V0R.W =  Unsafe.Add(ref selfRef, 7);

            this.V1L.X =  Unsafe.Add(ref selfRef, 8);
            this.V1L.Y =  Unsafe.Add(ref selfRef, 9);
            this.V1L.Z =  Unsafe.Add(ref selfRef, 10);
            this.V1L.W =  Unsafe.Add(ref selfRef, 11);
            this.V1R.X =  Unsafe.Add(ref selfRef, 12);
            this.V1R.Y =  Unsafe.Add(ref selfRef, 13);
            this.V1R.Z =  Unsafe.Add(ref selfRef, 14);
            this.V1R.W =  Unsafe.Add(ref selfRef, 15);

            this.V2L.X =  Unsafe.Add(ref selfRef, 16);
            this.V2L.Y =  Unsafe.Add(ref selfRef, 17);
            this.V2L.Z =  Unsafe.Add(ref selfRef, 18);
            this.V2L.W =  Unsafe.Add(ref selfRef, 19);
            this.V2R.X =  Unsafe.Add(ref selfRef, 20);
            this.V2R.Y =  Unsafe.Add(ref selfRef, 21);
            this.V2R.Z =  Unsafe.Add(ref selfRef, 22);
            this.V2R.W =  Unsafe.Add(ref selfRef, 23);

            this.V3L.X =  Unsafe.Add(ref selfRef, 24);
            this.V3L.Y =  Unsafe.Add(ref selfRef, 25);
            this.V3L.Z =  Unsafe.Add(ref selfRef, 26);
            this.V3L.W =  Unsafe.Add(ref selfRef, 27);
            this.V3R.X =  Unsafe.Add(ref selfRef, 28);
            this.V3R.Y =  Unsafe.Add(ref selfRef, 29);
            this.V3R.Z =  Unsafe.Add(ref selfRef, 30);
            this.V3R.W =  Unsafe.Add(ref selfRef, 31);

            this.V4L.X =  Unsafe.Add(ref selfRef, 32);
            this.V4L.Y =  Unsafe.Add(ref selfRef, 33);
            this.V4L.Z =  Unsafe.Add(ref selfRef, 34);
            this.V4L.W =  Unsafe.Add(ref selfRef, 35);
            this.V4R.X =  Unsafe.Add(ref selfRef, 36);
            this.V4R.Y =  Unsafe.Add(ref selfRef, 37);
            this.V4R.Z =  Unsafe.Add(ref selfRef, 38);
            this.V4R.W =  Unsafe.Add(ref selfRef, 39);

            this.V5L.X =  Unsafe.Add(ref selfRef, 40);
            this.V5L.Y =  Unsafe.Add(ref selfRef, 41);
            this.V5L.Z =  Unsafe.Add(ref selfRef, 42);
            this.V5L.W =  Unsafe.Add(ref selfRef, 43);
            this.V5R.X =  Unsafe.Add(ref selfRef, 44);
            this.V5R.Y =  Unsafe.Add(ref selfRef, 45);
            this.V5R.Z =  Unsafe.Add(ref selfRef, 46);
            this.V5R.W =  Unsafe.Add(ref selfRef, 47);

            this.V6L.X =  Unsafe.Add(ref selfRef, 48);
            this.V6L.Y =  Unsafe.Add(ref selfRef, 49);
            this.V6L.Z =  Unsafe.Add(ref selfRef, 50);
            this.V6L.W =  Unsafe.Add(ref selfRef, 51);
            this.V6R.X =  Unsafe.Add(ref selfRef, 52);
            this.V6R.Y =  Unsafe.Add(ref selfRef, 53);
            this.V6R.Z =  Unsafe.Add(ref selfRef, 54);
            this.V6R.W =  Unsafe.Add(ref selfRef, 55);

            this.V7L.X =  Unsafe.Add(ref selfRef, 56);
            this.V7L.Y =  Unsafe.Add(ref selfRef, 57);
            this.V7L.Z =  Unsafe.Add(ref selfRef, 58);
            this.V7L.W =  Unsafe.Add(ref selfRef, 59);
            this.V7R.X =  Unsafe.Add(ref selfRef, 60);
            this.V7R.Y =  Unsafe.Add(ref selfRef, 61);
            this.V7R.Z =  Unsafe.Add(ref selfRef, 62);
            this.V7R.W =  Unsafe.Add(ref selfRef, 63);
        }
	}
}
