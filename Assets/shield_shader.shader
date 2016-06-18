Shader "Custom/shield_shader" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "White" {}
        //_BumpMap ("Bumpmap", 2D) = "bump" {}
        _MaxDistance ("Effect Size", float) = 10
        _ShieldColor ("Color (RGBA)", Color) = (1, 1, 1, 0)
        _EmissionColor ("Emission color (RGB)", Color) = (1, 1, 1)
        _EffectTime ("Effect Time (ms)", float) = 500

        [HideInInspector]_ShieldHP ("Shield HP", float) = 1

        [HideInInspector]_RemainingTime0 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime1 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime2 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime3 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime4 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime5 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime6 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime7 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime8 ("Remaining Time (ms)", float) = 0
        [HideInInspector]_RemainingTime9 ("Remaining Time (ms)", float) = 0

        [HideInInspector]_Position0 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position1 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position2 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position3 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position4 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position5 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position6 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position7 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position8 ("Collision", Vector) = (-1, -1, -1, -1)
        [HideInInspector]_Position9 ("Collision", Vector) = (-1, -1, -1, -1)
    }

    SubShader {
        Tags {"QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent"}
        LOD 2000
        Cull OFF

        CGPROGRAM
        #pragma surface surf NoLight alpha:fade
        #pragma target 3.0

       //turn off lighting
       half4 LightingNoLight (SurfaceOutput s, half3 lightDir, half atten)
        {
            fixed4 c;
            c.rgb = s.Albedo; 
            c.a = s.Alpha;
            return c;
        }

        struct Input {
            float2 uv_MainTex;
            //float2 uv_BumpMap;
            float3 worldPos;
        };

        float4 _Position0;
        float4 _Position1;
        float4 _Position2;
        float4 _Position3;
        float4 _Position4;
        float4 _Position5;
        float4 _Position6;
        float4 _Position7;
        float4 _Position8;
        float4 _Position9;

        float  _MaxDistance;
        float4 _ShieldColor;
        float3 _EmissionColor;
        float  _EffectTime;
        float  _ShieldHP;

        float tempA;

        float  _RemainingTime0;
        float  _RemainingTime1;
        float  _RemainingTime2;
        float  _RemainingTime3;
        float  _RemainingTime4;
        float  _RemainingTime5;
        float  _RemainingTime6;
        float  _RemainingTime7;
        float  _RemainingTime8;
        float  _RemainingTime9;

        sampler2D _MainTex;
        //sampler2D _BumpMap;

        void surf (Input IN, inout SurfaceOutput o)
        {
            half4 c = tex2D (_MainTex, IN.uv_MainTex);

            o.Albedo = c.rgb * _ShieldColor.rgb;
            //o.Normal = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap));
            o.Emission = c.rgb * _EmissionColor.rgb;
            o.Alpha = _ShieldColor.a * _ShieldHP;

            float myDist0 = distance(_Position0.xyz, IN.worldPos);
            float myDist1 = distance(_Position1.xyz, IN.worldPos);
            float myDist2 = distance(_Position2.xyz, IN.worldPos);
            float myDist3 = distance(_Position3.xyz, IN.worldPos);
            float myDist4 = distance(_Position4.xyz, IN.worldPos);
            float myDist5 = distance(_Position5.xyz, IN.worldPos);
            float myDist6 = distance(_Position6.xyz, IN.worldPos);
            float myDist7 = distance(_Position7.xyz, IN.worldPos);
            float myDist8 = distance(_Position8.xyz, IN.worldPos);
            float myDist9 = distance(_Position9.xyz, IN.worldPos);

            if(_RemainingTime0 > 0 && myDist0 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime0 / _EffectTime - myDist0 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
            if(_RemainingTime1 > 0 && myDist1 < _MaxDistance)
            {
               tempA = clamp(_RemainingTime1 / _EffectTime - myDist1 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
            if(_RemainingTime2 > 0 && myDist2 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime2 / _EffectTime - myDist2 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
            if(_RemainingTime3 > 0 && myDist3 < _MaxDistance)
            {
            tempA = clamp(_RemainingTime3 / _EffectTime - myDist3 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
            if(tempA > o.Alpha)
                o.Alpha = tempA;
            }
            if(_RemainingTime4 > 0 && myDist4 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime4 / _EffectTime - myDist4 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
        }
            if(_RemainingTime5 > 0 && myDist5 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime5 / _EffectTime - myDist5 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
             }
            if(_RemainingTime6 > 0 && myDist6 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime6 / _EffectTime - myDist6 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
            if(_RemainingTime7 > 0 && myDist7 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime7 / _EffectTime - myDist7 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
             }
            if(_RemainingTime8 > 0 && myDist8 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime8 / _EffectTime - myDist8 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
            if(_RemainingTime9 > 0 && myDist9 < _MaxDistance)
            {
                tempA = clamp(_RemainingTime9 / _EffectTime - myDist9 / _MaxDistance, _ShieldColor.a, 1) * _ShieldHP;
                if(tempA > o.Alpha)
                    o.Alpha = tempA;
            }
        }   

        ENDCG
    } 
   Fallback "Transparent/Diffuse"
   }
